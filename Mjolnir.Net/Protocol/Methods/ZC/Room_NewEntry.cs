using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x00d7, size: MethodAttribute.packet_length_dynamic, name: "ZC_ROOM_NEWENTRY", direction: MethodAttribute.packetdirection.pd_in)]
    public class Room_NewEntry : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}