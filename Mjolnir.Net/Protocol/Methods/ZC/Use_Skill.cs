using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x011a, size: 15, name: "ZC_USE_SKILL", direction: MethodAttribute.packetdirection.pd_in)]
    public class UseSkill : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}