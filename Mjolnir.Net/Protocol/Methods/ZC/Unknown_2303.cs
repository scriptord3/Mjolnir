using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x08ff, size: 24, name: "ZC_UNKNOWN_2303", direction: MethodAttribute.packetdirection.pd_in)]
    public class Unknown_2303 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}