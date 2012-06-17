using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0814, size: 86, name: "ZC_BUYING_STORE_ENTRY", direction: MethodAttribute.packetdirection.pd_in)]
    public class Buying_Store_Entry : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}