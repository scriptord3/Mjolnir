using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x013a, size: 4, name: "ZC_ATTACK_RANGE", direction: MethodAttribute.packetdirection.pd_in)]
    public class Attack_Range : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}