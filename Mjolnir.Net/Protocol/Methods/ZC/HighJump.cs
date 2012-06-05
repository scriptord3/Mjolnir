using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x01ff, size: 10, name: "ZC_HIGHJUMP", direction: MethodAttribute.packetdirection.pd_in)]
    public class HighJump : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}