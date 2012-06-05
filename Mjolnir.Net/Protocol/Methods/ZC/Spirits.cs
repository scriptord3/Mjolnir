using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x01d0, size: 8, name: "ZC_SPIRITS", direction: MethodAttribute.packetdirection.pd_in)]
    public class Spirits : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}