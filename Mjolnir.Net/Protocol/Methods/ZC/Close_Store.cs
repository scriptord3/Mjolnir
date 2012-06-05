using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x00f8, size: 2, name: "ZC_CLOSE_STORE", direction: MethodAttribute.packetdirection.pd_in)]
    public class Close_Store : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}