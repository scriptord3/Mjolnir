using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x02c9, size: 3, name: "ZC_PARTY_CONFIG", direction: MethodAttribute.packetdirection.pd_in)]
    public class Party_Config : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}