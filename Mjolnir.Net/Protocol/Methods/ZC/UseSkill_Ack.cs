using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x013e, size: 24, name: "ZC_USESKILL_ACK", direction: MethodAttribute.packetdirection.pd_in)]
    public class UseSkill_Ack : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}