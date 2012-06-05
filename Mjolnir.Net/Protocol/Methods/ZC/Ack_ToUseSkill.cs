using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0110, size: 10, name: "ZC_ACK_TOUSESKILL", direction: MethodAttribute.packetdirection.pd_in)]
    public class Ack_ToUseSkill : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}