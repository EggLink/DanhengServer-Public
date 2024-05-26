﻿using EggLink.DanhengServer.Enums;
using EggLink.DanhengServer.Util;
using SqlSugar;

namespace EggLink.DanhengServer.Database.Mission
{
    [SugarTable("Mission")]
    public class MissionData : BaseDatabaseDataHelper
    {
        [SugarColumn(IsJson = true)]
        public Dictionary<int, Dictionary<int, MissionInfo>> MissionInfo { get; set; } = [];  // Dictionary<MissionId, Dictionary<SubMissionId, MissionInfo>> // seems like main missionId is not used
        [SugarColumn(IsJson = true)]
        public Dictionary<int, MissionPhaseEnum> MainMissionInfo { get; set; } = [];  // Dictionary<MissionId, MissionPhaseEnum>

        [SugarColumn(IsJson = true, ColumnDataType = "text")]
        public List<int> FinishedSubMissionIds { get; set; } = [];
        [SugarColumn(IsJson = true, ColumnDataType = "text")]
        public List<int> RunningSubMissionIds { get; set; } = [];

        [SugarColumn(IsJson = true)]
        public List<int> FinishedMainMissionIds { get; set; } = [];
        [SugarColumn(IsJson = true)]
        public List<int> RunningMainMissionIds { get; set; } = [];

        public MissionPhaseEnum GetMainMissionStatus(int missionId)
        {
            if (FinishedMainMissionIds.Contains(missionId))
            {
                return MissionPhaseEnum.Finish;
            }
            if (RunningMainMissionIds.Contains(missionId))
            {
                return MissionPhaseEnum.Doing;
            }
            return MissionPhaseEnum.None;
        }

        public MissionPhaseEnum GetSubMissionStatus(int missionId)
        {
            if (FinishedSubMissionIds.Contains(missionId))
            {
                return MissionPhaseEnum.Finish;
            }
            if (RunningSubMissionIds.Contains(missionId))
            {
                return MissionPhaseEnum.Doing;
            }
            return MissionPhaseEnum.None;
        }

        public void SetMainMissionStatus(int missionId, MissionPhaseEnum phase)
        {
            if (phase == MissionPhaseEnum.Finish)
            {
                FinishedMainMissionIds.SafeAdd(missionId);
                RunningMainMissionIds.Remove(missionId);
            }
            else if (phase == MissionPhaseEnum.Doing)
            {
                FinishedMainMissionIds.Remove(missionId);
                RunningMainMissionIds.SafeAdd(missionId);
            }
            else
            {
                FinishedMainMissionIds.Remove(missionId);
                RunningMainMissionIds.Remove(missionId);
            }
        }

        public void SetSubMissionStatus(int missionId, MissionPhaseEnum phase)
        {
            if (phase == MissionPhaseEnum.Finish)
            {
                FinishedSubMissionIds.SafeAdd(missionId);
                RunningSubMissionIds.Remove(missionId);
            }
            else if (phase == MissionPhaseEnum.Doing)
            {
                FinishedSubMissionIds.Remove(missionId);
                RunningSubMissionIds.SafeAdd(missionId);
            }
            else
            {
                FinishedSubMissionIds.Remove(missionId);
                RunningSubMissionIds.Remove(missionId);
            }
        }

        public void MoveFromOld()
        {
            foreach (var main in MissionInfo)
            {
                foreach (var sub in main.Value)
                {
                    if (sub.Value.Status == MissionPhaseEnum.Finish)
                    {
                        FinishedSubMissionIds.SafeAdd(sub.Key);
                    }
                    else if (sub.Value.Status == MissionPhaseEnum.Doing)
                    {
                        RunningSubMissionIds.SafeAdd(sub.Key);
                    }
                }
            }

            MissionInfo.Clear();

            foreach (var main in MainMissionInfo)
            {
                if (main.Value == MissionPhaseEnum.Finish)
                {
                    FinishedMainMissionIds.SafeAdd(main.Key);
                }
                else if (main.Value == MissionPhaseEnum.Doing)
                {
                    RunningMainMissionIds.SafeAdd(main.Key);
                }
            }

            MainMissionInfo.Clear();

            DatabaseHelper.Instance!.UpdateInstance(this);
        }
    }

    public class MissionInfo
    {
        public int MissionId { get; set; }
        public MissionPhaseEnum Status { get; set; }
    }
}
