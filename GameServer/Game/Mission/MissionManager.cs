﻿using EggLink.DanhengServer.Data;
using EggLink.DanhengServer.Database;
using EggLink.DanhengServer.Database.Inventory;
using EggLink.DanhengServer.Database.Mission;
using EggLink.DanhengServer.Enums;
using EggLink.DanhengServer.Enums.Item;
using EggLink.DanhengServer.Game.Mission.FinishAction;
using EggLink.DanhengServer.Game.Mission.FinishType;
using EggLink.DanhengServer.Game.Player;
using EggLink.DanhengServer.GameServer.Server.Packet.Send.HeartDial;
using EggLink.DanhengServer.Plugin.Event;
using EggLink.DanhengServer.Server.Packet.Send.Lineup;
using EggLink.DanhengServer.Server.Packet.Send.Mission;
using EggLink.DanhengServer.Server.Packet.Send.Player;
using EggLink.DanhengServer.Server.Packet.Send.Scene;
using EggLink.DanhengServer.Util;
using System.Reflection;

namespace EggLink.DanhengServer.Game.Mission
{
    public class MissionManager : BasePlayerManager
    {
        #region Initializer & Properties

        public MissionData Data { get; set; }
        public Dictionary<FinishActionTypeEnum, MissionFinishActionHandler> ActionHandlers = [];
        public Dictionary<MissionFinishTypeEnum, MissionFinishTypeHandler> FinishTypeHandlers = [];

        public readonly List<int> SkipSubMissionList = []; // bug

        public MissionManager(PlayerInstance player) : base(player)
        {
            Data = DatabaseHelper.Instance!.GetInstanceOrCreateNew<MissionData>(player.Uid);

            var types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in types)
            {
                var attr = type.GetCustomAttribute<MissionFinishActionAttribute>();
                if (attr != null)
                {
                    var handler = (MissionFinishActionHandler)Activator.CreateInstance(type, null)!;
                    ActionHandlers.Add(attr.FinishAction, handler);
                }
                var attr2 = type.GetCustomAttribute<MissionFinishTypeAttribute>();
                if (attr2 != null)
                {
                    var handler = (MissionFinishTypeHandler)Activator.CreateInstance(type, null)!;
                    FinishTypeHandlers.Add(attr2.FinishType, handler);
                }
            }
        }

        #endregion

        #region Mission Actions

        public List<Proto.MissionSync?> AcceptMainMission(int missionId, bool sendPacket = true)
        {
            if (!ConfigManager.Config.ServerOption.EnableMission) return [];
            if (Data.GetMainMissionStatus(missionId) != MissionPhaseEnum.None) return [];  // already accepted
            // Get entry sub mission
            GameData.MainMissionData.TryGetValue(missionId, out var mission);
            if (mission == null) return [];

            Data.SetMainMissionStatus(missionId, MissionPhaseEnum.Accept);

            var list = new List<Proto.MissionSync?>();
            mission.MissionInfo?.StartSubMissionList.ForEach(i => list.Add(AcceptSubMission(i, sendPacket)));
            if (missionId == 4030001 || missionId == 4030002)
            {
                // skip  not implemented
                mission.MissionInfo?.SubMissionList.ForEach(x=> AcceptSubMission(x.ID));
                mission.MissionInfo?.SubMissionList.ForEach(x => FinishSubMission(x.ID));
            }

            if (missionId == 1000400)
            {
                Player.AddAvatar(1003);
                Player.LineupManager!.AddAvatarToCurTeam(1003);
            }

            return list;
        }

        public Proto.MissionSync AcceptMainMissionByCondition(bool sendPacket = true)
        {
            var sync = new Proto.MissionSync();
            foreach (var nextMission in GameData.MainMissionData.Values)
            {
                if (!nextMission.IsEqual(Data)) continue;
                if (Data.GetMainMissionStatus(nextMission.MainMissionID) != MissionPhaseEnum.None) continue;  // already accepted
                var res = AcceptMainMission(nextMission.MainMissionID, sendPacket);
                foreach (var subMission in res)
                {
                    if (subMission != null)
                    {
                        sync.MissionList.AddRange(subMission.MissionList);
                    }
                }
            }

            return sync;
        }

        public List<Proto.MissionSync?> ReAcceptMainMission(int missionId, bool sendPacket = true)
        {
            if (!ConfigManager.Config.ServerOption.EnableMission) return [];

            GameData.MainMissionData.TryGetValue(missionId, out var mission);
            if (mission == null) return [];
            Proto.MissionSync sync = new();

            foreach (var subMission in mission.SubMissionIds)
            {
                if (Data.GetSubMissionStatus(subMission) == MissionPhaseEnum.Finish || Data.GetSubMissionStatus(subMission) == MissionPhaseEnum.Accept)
                {
                    sync.MissionList.Add(new Proto.Mission()
                    {
                        Id = (uint)subMission,
                        Status = Proto.MissionStatus.MissionNone,
                    });
                }
            }

            foreach (var subMission in mission.SubMissionIds)
            { 
                Data.SetSubMissionStatus(subMission, MissionPhaseEnum.None);  // reset
            }

            Data.SetMainMissionStatus(missionId, MissionPhaseEnum.None);  // reset
            Player.SendPacket(new PacketPlayerSyncScNotify(sync));

            return AcceptMainMission(missionId, sendPacket);
        }

        public void RemoveMainMission(int missionId)
        {
            if (!ConfigManager.Config.ServerOption.EnableMission) return;
            Data.SetMainMissionStatus(missionId, MissionPhaseEnum.None);

            GameData.MainMissionData.TryGetValue(missionId, out var mission);
            if (mission == null) return;

            Proto.MissionSync sync = new();

            foreach (var subMission in mission.SubMissionIds)
            {
                Data.SetSubMissionStatus(subMission, MissionPhaseEnum.None);
                SetMissionProgress(subMission, 0);
                sync.MissionList.Add(new Proto.Mission()
                {
                    Id = (uint)subMission,
                    Status = Proto.MissionStatus.MissionNone,
                });
            }

            Player.SendPacket(new PacketPlayerSyncScNotify(sync));
        }

        public void AcceptSubMission(int missionId)
        {
            if (!ConfigManager.Config.ServerOption.EnableMission) return;
            AcceptSubMission(missionId, true);
        }

        public Proto.MissionSync? AcceptSubMission(int missionId, bool sendPacket, bool doFinishTypeAction = true)
        {
            if (!ConfigManager.Config.ServerOption.EnableMission) return null;
            GameData.SubMissionData.TryGetValue(missionId, out var mission);
            if (mission == null) return null;
            if (Data.GetSubMissionStatus(missionId) != MissionPhaseEnum.None) return null;  // already accepted

            Data.SetSubMissionStatus(missionId, MissionPhaseEnum.Accept);

            var sync = new Proto.MissionSync();
            sync.MissionList.Add(new Proto.Mission()
            {
                Id = (uint)missionId,
                Status = Proto.MissionStatus.MissionDoing,
            });

            DatabaseHelper.Instance?.UpdateInstance(Data);
            if (sendPacket) Player.SendPacket(new PacketPlayerSyncScNotify(sync));
            Player.SceneInstance!.SyncGroupInfo();
            if (mission.SubMissionInfo != null)
            {
                try
                {
                    FinishTypeHandlers.TryGetValue(mission.SubMissionInfo.FinishType, out var handler);
                    handler?.Init(Player, mission.SubMissionInfo, null);
                    if (doFinishTypeAction)
                        handler?.HandleFinishType(Player, mission.SubMissionInfo, null);
                } catch
                {
                }
            }

            if (SkipSubMissionList.Contains(missionId))
            {
                //FinishSubMission(missionId);
            }

            if (mission.SubMissionInfo?.LevelFloorID == Player.SceneInstance?.FloorId)
            {
                if (mission.SubMissionInfo?.GroupIDList != null)
                {
                    foreach (var group in mission.SubMissionInfo.GroupIDList)
                    {
                        Player.SceneInstance?.EntityLoader?.LoadGroup(group);
                    }
                }
            }

            // TODO: Mission Task
            Player.TaskManager?.MissionTaskTrigger?.TriggerMissionTask(missionId);

            return sync;
        }

        public void FinishMainMission(int missionId)
        {
            if (!ConfigManager.Config.ServerOption.EnableMission) return;
            if (!GameData.MainMissionData.TryGetValue(missionId, out var mainMission)) return;
            if (Data.GetMainMissionStatus(missionId) != MissionPhaseEnum.Accept) return;
            Data.SetMainMissionStatus(missionId, MissionPhaseEnum.Finish);
            var sync = new Proto.MissionSync();
            sync.MainMissionIdList.Add((uint)missionId);
            // get next main mission
            foreach (var mission in mainMission.SubMissionIds)
            {
                if (GetSubMissionStatus(mission) != MissionPhaseEnum.Finish)
                {
                    if (Data.GetSubMissionStatus(mission) != MissionPhaseEnum.Finish)
                    {
                        Data.SetSubMissionStatus(mission, MissionPhaseEnum.Finish);
                        sync.MissionList.Add(new Proto.Mission()
                        {
                            Id = (uint)mission,
                            Status = Proto.MissionStatus.MissionFinish,
                        });
                    }
                }
            }

            var mainSync = AcceptMainMissionByCondition(false);
            sync.MissionList.AddRange(mainSync.MissionList);

            Player.SendPacket(new PacketPlayerSyncScNotify(sync));
            Player.SendPacket(new PacketStartFinishMainMissionScNotify(missionId));
            HandleMissionReward(missionId);
            HandleFinishType(MissionFinishTypeEnum.FinishMission);

            Player.RaidManager!.CheckIfLeaveRaid();

            PluginEvent.InvokeOnPlayerFinishMainMission(Player, missionId);
        }

        public void FinishSubMission(int missionId)
        {
            if (!ConfigManager.Config.ServerOption.EnableMission) return;
            GameData.SubMissionData.TryGetValue(missionId, out var subMission);
            if (subMission == null) return;
            var mainMissionId = subMission.MainMissionID;
            if (Data.GetSubMissionStatus(missionId) != MissionPhaseEnum.Accept) return;  // not accepted
            GameData.MainMissionData.TryGetValue(mainMissionId, out var mainMission);  // get main mission
            if (mainMission == null) return;
            Data.SetSubMissionStatus(missionId, MissionPhaseEnum.Finish);  // set finish

            SetMissionProgress(missionId, subMission.SubMissionInfo?.Progress ?? 1);

            var sync = new Proto.MissionSync();
            sync.MissionList.Add(new Proto.Mission()
            {
                Id = (uint)missionId,
                Status = Proto.MissionStatus.MissionFinish,
                Progress = (uint)(subMission.SubMissionInfo?.Progress ?? 1)
            });

            var subMissionInfo = subMission?.SubMissionInfo;

            // get next sub mission
            foreach (var nextMission in mainMission.MissionInfo?.SubMissionList ?? [])
            {
                if (nextMission.TakeType != SubMissionTakeTypeEnum.AnySequence && nextMission.TakeType != SubMissionTakeTypeEnum.MultiSequence) continue;
                bool canAccept = nextMission.TakeType == SubMissionTakeTypeEnum.MultiSequence;  // mean and operation
                foreach (var id in nextMission.TakeParamIntList ?? [])
                {
                    if (GetSubMissionStatus(id) != MissionPhaseEnum.Finish && nextMission.TakeType == SubMissionTakeTypeEnum.MultiSequence)
                    {
                        canAccept = false;
                        break;
                    }
                    else if (GetSubMissionStatus(id) == MissionPhaseEnum.Finish && nextMission.TakeType == SubMissionTakeTypeEnum.AnySequence)  // or operation
                    {
                        canAccept = true;
                        break;
                    }
                }
                if (canAccept)
                {
                    var s = AcceptSubMission(nextMission.ID, false, false);
                    if (s != null)
                    {
                        sync.MissionList.Add(new Proto.Mission()
                        {
                            Id = (uint)nextMission.ID,
                            Status = Proto.MissionStatus.MissionDoing,
                        });
                    }
                }
            }
            Player.SendPacket(new PacketPlayerSyncScNotify(sync));
            Player.SendPacket(new PacketStartFinishSubMissionScNotify(missionId));

            if (mainMission.MissionInfo != null)
                HandleFinishAction(mainMission.MissionInfo, missionId);

            // Get if it should finish main mission
            // get current main mission
            var shouldFinish = true;
            mainMission.MissionInfo?.FinishSubMissionList.ForEach(id =>
            {
                if (GetSubMissionStatus(id) != MissionPhaseEnum.Finish)
                {
                    shouldFinish = false;
                }
            });

            foreach (var nextMission in GetRunningSubMissionList())
            {
                FinishTypeHandlers.TryGetValue(nextMission.FinishType, out var handler);
                handler?.HandleFinishType(Player, nextMission, null);
            }

            if (shouldFinish)
            {
                FinishMainMission(mainMissionId);
            }

            if (missionId == 101140201)
            {
                //Player.ChangeHeroBasicType(Enums.Avatar.HeroBasicTypeEnum.Knight);
                var list = Player.LineupManager!.GetCurLineup()!.BaseAvatars!.Select(x => x.SpecialAvatarId > 0 ? x.SpecialAvatarId / 10 : x.BaseAvatarId).ToList();
                list[list.IndexOf(8001)] = Player.Data.CurrentGender == Proto.Gender.Man ? 1008003 : 1008004;
                Player.LineupManager!.SetExtraLineup(Proto.ExtraLineupType.LineupHeliobus, list);
            }

            if (missionId == 103040103)
            {
                Player.SendPacket(new PacketHeartDialScriptChangeScNotify(Proto.HeartDialUnlockStatus.UnlockSingle));
            }

            if (missionId == 103040104)
            {
                Player.SendPacket(new PacketHeartDialScriptChangeScNotify(Proto.HeartDialUnlockStatus.UnlockAll));
            }

            // handle reward
            HandleSubMissionReward(missionId);
            //Player.StoryLineManager!.CheckIfEnterStoryLine();
            //Player.StoryLineManager!.CheckIfFinishStoryLine();

            PluginEvent.InvokeOnPlayerFinishSubMission(Player, missionId);
        }

        public void HandleFinishAction(Data.Config.MissionInfo info, int subMissionId)
        {
            var subMission = info.SubMissionList.Find(x => x.ID == subMissionId);
            if (subMission == null) return;

            foreach (var action in subMission.FinishActionList ?? [])
            {
                HandleFinishAction(action);
            }
        }

        public void HandleFinishAction(Data.Config.FinishActionInfo actionInfo)
        {
            ActionHandlers.TryGetValue(actionInfo.FinishActionType, out var handler);
            handler?.OnHandle(actionInfo.FinishActionPara, actionInfo.FinishActionParaString, Player);
        }

        public void HandleMissionReward(int mainMissionId)
        {
            GameData.MainMissionData.TryGetValue(mainMissionId, out var mainMission);
            if (mainMission == null) return;
            GameData.RewardDataData.TryGetValue(mainMission.RewardID, out var reward);
            var ItemList = new Proto.ItemList();
            reward?.GetItems().ForEach(i =>
            {
                GameData.ItemConfigData.TryGetValue(i.Item1, out var item);
                var res = Player.InventoryManager!.AddItem(i.Item1, i.Item2, item?.ItemMainType == ItemMainTypeEnum.AvatarCard);
                if (res != null)
                {
                    ItemList.ItemList_.Add(res.ToProto());
                }
            });

            mainMission.SubRewardList.ForEach(i =>
            {
                GameData.RewardDataData.TryGetValue(i, out var reward);
                reward?.GetItems().ForEach(j =>
                {
                    GameData.ItemConfigData.TryGetValue(j.Item1, out var item);
                    var res = Player.InventoryManager!.AddItem(j.Item1, j.Item2, item?.ItemMainType == ItemMainTypeEnum.AvatarCard);
                    if (res != null)
                    {
                        ItemList.ItemList_.Add(res.ToProto());
                    }
                });
            });

            Player.SendPacket(new PacketMissionRewardScNotify(mainMissionId, 0, ItemList));
            Player.SendPacket(new PacketScenePlaneEventScNotify(ItemList));
        }

        public void HandleSubMissionReward(int subMissionId)
        {
            GameData.SubMissionData.TryGetValue(subMissionId, out var subMission);
            if (subMission == null) return;
            GameData.RewardDataData.TryGetValue(subMission.SubMissionInfo?.SubRewardID ?? 0, out var reward);
            var ItemList = new Proto.ItemList();
            reward?.GetItems().ForEach(i =>
            {
                var res = Player.InventoryManager!.AddItem(i.Item1, i.Item2, false);
                if (res != null)
                {
                    ItemList.ItemList_.Add(res.ToProto());
                }
            });

            Player.SendPacket(new PacketMissionRewardScNotify(0, subMissionId, ItemList));
            Player.SendPacket(new PacketScenePlaneEventScNotify(ItemList));
        }

        public void HandleFinishType(MissionFinishTypeEnum finishType, object? arg = null)
        {
            FinishTypeHandlers.TryGetValue(finishType, out var handler);
            foreach (var mission in GetRunningSubMissionList())
            {
                if (mission.FinishType == finishType)
                {
                    handler?.HandleFinishType(Player, mission, arg);
                }
            }
        }

        public void HandleTalkStr(string talkString)
        {
            if (!ConfigManager.Config.ServerOption.EnableMission) return;

            foreach (var mission in GetRunningSubMissionList())
            {
                if (mission.FinishType == MissionFinishTypeEnum.Talk)
                {
                    if (mission.ParamStr1 == talkString)
                    {
                        FinishSubMission(mission.ID);
                    }
                }
            }
        }

        public void HandleCustomValue(List<Proto.MissionCustomValue> values, int missionId)
        {
            if (!ConfigManager.Config.ServerOption.EnableMission) return;

            GameData.SubMissionData.TryGetValue(missionId, out var subMission);
            if (subMission == null) return;
            var mainMissionId = subMission.MainMissionID;
            GameData.MainMissionData.TryGetValue(mainMissionId, out var mainMission);
            if (mainMission == null) return;

            foreach (var mission in mainMission?.MissionInfo?.SubMissionList ?? [])
            {
                if (mission.TakeType == SubMissionTakeTypeEnum.CustomValue)
                {
                    int index = 0;
                    bool accept = true;
                    foreach (var customValue in mission.TakeParamIntList ?? [])
                    {
                        if (customValue == 0 && index == 0) continue;  // skip 0
                        var valueInst = values.Find(x => x.Index == index);
                        if (valueInst == null) continue;
                        if (valueInst.CustomValue != customValue)
                        {
                            accept = false;
                            break;
                        }
                    }

                    if (accept)
                    {
                        AcceptSubMission(mission.ID);
                    }
                }
            }
        }

        public void AddMissionProgress(int missionId, int progress)
        {
            if (!ConfigManager.Config.ServerOption.EnableMission) return;

            Data.SubMissionProgressDict.TryGetValue(missionId, out var currentProgress);
            Data.SubMissionProgressDict[missionId] = currentProgress + progress;
            GameData.SubMissionData.TryGetValue(missionId, out var subMission);
            if (subMission == null) return;

            if ((currentProgress + progress) >= (subMission.SubMissionInfo?.Progress ?? 1))
            {
                return;
            }

            var sync = new Proto.MissionSync();
            sync.MissionList.Add(new Proto.Mission()
            {
                Id = (uint)missionId,
                Progress = (uint)(currentProgress + progress),
            });

            Player.SendPacket(new PacketPlayerSyncScNotify(sync));
        }

        public void SetMissionProgress(int missionId, int progress)
        {
            if (!ConfigManager.Config.ServerOption.EnableMission) return;

            Data.SubMissionProgressDict[missionId] = progress;
            GameData.SubMissionData.TryGetValue(missionId, out var subMission);
            if (subMission == null) return;

            if (progress >= (subMission.SubMissionInfo?.Progress ?? 1))
            {
                return;
            }

            var sync = new Proto.MissionSync();
            sync.MissionList.Add(new Proto.Mission()
            {
                Id = (uint)missionId,
                Progress = (uint)progress,
            });

            Player.SendPacket(new PacketPlayerSyncScNotify(sync));
        }

        #endregion

        #region Mission Status

        public MissionPhaseEnum GetMainMissionStatus(int missionId)
        {
            if (!ConfigManager.Config.ServerOption.EnableMission) return MissionPhaseEnum.Finish;

            return Data.GetMainMissionStatus(missionId);
        }

        public MissionPhaseEnum GetSubMissionStatus(int missionId)
        {
            if (!ConfigManager.Config.ServerOption.EnableMission) return MissionPhaseEnum.Finish;

            return Data.GetSubMissionStatus(missionId);
        }

        public Data.Config.SubMissionInfo? GetSubMissionInfo(int missionId)
        {
            GameData.SubMissionData.TryGetValue(missionId, out var subMission);
            if (subMission == null) return null;
            return subMission.SubMissionInfo;
        }

        public List<int> GetRunningSubMissionIdList()
        {
            if (!ConfigManager.Config.ServerOption.EnableMission) return [];

            var list = new List<int>();
            foreach (var id in Data.RunningSubMissionIds)
            {
                list.Add(id);
            }
            return list;
        }

        public List<Data.Config.SubMissionInfo> GetRunningSubMissionList()
        {
            if (!ConfigManager.Config.ServerOption.EnableMission) return [];

            var list = new List<Data.Config.SubMissionInfo>();
            foreach (var id in Data.RunningSubMissionIds)
            {
                GameData.SubMissionData.TryGetValue(id, out var mission);
                if (mission != null && mission.SubMissionInfo != null)
                {
                    list.Add(mission.SubMissionInfo);
                }
            }
            return list;
        }

        public int GetMissionProgress(int missionId)
        {
            GameData.SubMissionData.TryGetValue(missionId, out var subMission);
            if (!ConfigManager.Config.ServerOption.EnableMission) return subMission?.SubMissionInfo?.Progress ?? 0;

            Data.SubMissionProgressDict.TryGetValue(missionId, out var progress);
            return progress;
        }

        #endregion

        #region Handlers

        public void OnBattleFinish(Proto.PVEBattleResultCsReq req)
        {
            foreach (var mission in GetRunningSubMissionIdList())
            {
                var subMission = GetSubMissionInfo(mission);
                if (subMission != null && subMission.FinishType == MissionFinishTypeEnum.StageWin && req.EndStatus == Proto.BattleEndStatus.BattleEndWin)  // TODO: Move to handler
                {
                    if (req.StageId.ToString().StartsWith(subMission.ParamInt1.ToString()))
                    {
                        FinishSubMission(mission);
                    }
                }
            }
        }

        public void OnPlayerInteractWithProp()
        {
            foreach (var id in GetRunningSubMissionIdList())
            {
                if (GetSubMissionInfo(id)?.FinishType == MissionFinishTypeEnum.PropState)
                {
                    FinishTypeHandlers.TryGetValue(MissionFinishTypeEnum.PropState, out var handler);
                    handler?.HandleFinishType(Player, GetSubMissionInfo(id)!, null);
                }
            }
        }
        
        public void OnPlayerChangeScene()
        {
            foreach (var id in GetRunningSubMissionIdList())
            {
                var info = GetSubMissionInfo(id);
                if (info == null) continue;

                if (info.LevelFloorID == Player.SceneInstance?.FloorId)
                {
                    if (info.GroupIDList == null) continue;
                    foreach (var group in info.GroupIDList)
                    {
                        Player.SceneInstance.EntityLoader!.LoadGroup(group, false);
                    }
                }
            }
        }

        public void OnLoadScene(Proto.SceneInfo info)
        {
            foreach (var mainMission in GameData.MainMissionData.Values)
            {
                foreach (var subMission in mainMission.MissionInfo?.SubMissionList ?? [])
                {
                    if (subMission.LevelFloorID == info.FloorId)
                    {
                        info.SceneMissionInfo.SceneSubMissionList.Add(new Proto.Mission()
                        {
                            Id = (uint)subMission.ID,
                            Status = GetSubMissionStatus(subMission.ID).ToProto(),
                            Progress = (uint)GetMissionProgress(subMission.ID),
                        });
                    }
                }

                foreach (var subMission in mainMission.MissionInfo?.SubMissionList ?? [])
                {
                    if (subMission.LevelFloorID == info.FloorId)
                    {
                        if (GetMainMissionStatus(mainMission.MainMissionID) == MissionPhaseEnum.Finish)
                        {
                            info.SceneMissionInfo.MainMissionIdList.Add((uint)mainMission.MainMissionID);
                        } else if (GetMainMissionStatus(mainMission.MainMissionID) == MissionPhaseEnum.Accept)
                        {
                            info.SceneMissionInfo.AcceptMainMissionIdList.Add((uint)mainMission.MainMissionID);
                        }
                        break;  // only one
                    }
                }
            }
        }

        #endregion
    }
}
