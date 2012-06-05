using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0092, size: 28, name: "ZC_NPCACK_SERVERMOVE", direction: MethodAttribute.packetdirection.pd_in)]
    public class NpcAck_ServerMove : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}