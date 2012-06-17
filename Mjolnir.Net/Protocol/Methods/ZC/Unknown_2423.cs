using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0977, size: 14, name: "ZC_UNKNOWN_2423", direction: MethodAttribute.packetdirection.pd_in)]
    public class Unknown_2423 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}