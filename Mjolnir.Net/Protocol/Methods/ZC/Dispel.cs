using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x01b9, size: 6, name: "ZC_DISPEL", direction: MethodAttribute.packetdirection.pd_in)]
    public class Dispel : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}