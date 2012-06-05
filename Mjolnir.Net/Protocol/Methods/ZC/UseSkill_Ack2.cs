using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x07fb, size: 25, name: "ZC_USESKILL_ACK2", direction: MethodAttribute.packetdirection.pd_in)]
    public class UseSkill_Ack2 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}