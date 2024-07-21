﻿using EggLink.DanhengServer.Data.Config;
using EggLink.DanhengServer.Enums;
using EggLink.DanhengServer.Game.Player;
using EggLink.DanhengServer.Server.Packet.Send.Player;

namespace EggLink.DanhengServer.Game.Mission.FinishType.Handler
{
    [MissionFinishType(MissionFinishTypeEnum.SubMissionFinishCnt)]
    public class MissionHandlerSubMissionFinishCnt : MissionFinishTypeHandler
    {
        public override void Init(PlayerInstance player, SubMissionInfo info, object? arg)
        {
            // Do nothing
        }

        public override void HandleFinishType(PlayerInstance player, SubMissionInfo info, object? arg)
        {
            var finishCount = 0;
            foreach (var missionId in info.ParamIntList ?? [])
            {
                var status = player.MissionManager!.GetSubMissionStatus(missionId);
                if (status == MissionPhaseEnum.Finish || status == MissionPhaseEnum.Cancel)
                {
                    finishCount++;
                }
            }
            if (finishCount >= info.Progress)  // finish count >= progress, finish mission
            {
                player.MissionManager!.FinishSubMission(info.ID);
            } else  // update progress
            {
                if (player.MissionManager!.GetMissionProgress(info.ID) != finishCount)
                {
                    player.MissionManager!.SetMissionProgress(info.ID, finishCount);
                }
            }
        }
    }
}
