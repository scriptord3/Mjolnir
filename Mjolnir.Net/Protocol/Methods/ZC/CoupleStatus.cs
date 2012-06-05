using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0141, size: 14, name: "ZC_COUPLESTATUS", direction: MethodAttribute.packetdirection.pd_in)]
    public class CoupleStatus : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}