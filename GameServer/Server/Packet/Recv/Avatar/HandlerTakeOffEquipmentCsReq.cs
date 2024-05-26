﻿using EggLink.DanhengServer.Proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Server.Packet.Recv.Avatar
{
    [Opcode(CmdIds.TakeOffEquipmentCsReq)]
    public class HandlerTakeOffEquipmentCsReq : Handler
    {
        public override void OnHandle(Connection connection, byte[] header, byte[] data)
        {
            var req = TakeOffEquipmentCsReq.Parser.ParseFrom(data);
            connection.Player!.InventoryManager!.UnequipEquipment((int)req.DressAvatarId);

            connection.SendPacket(CmdIds.TakeOffEquipmentScRsp);
        }
    }
}
