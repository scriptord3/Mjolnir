using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0091, size: 22, name: "ZC_NPCACK_MAPMOVE", direction: MethodAttribute.packetdirection.pd_in)]
    public class NpcAck_MapMove : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}