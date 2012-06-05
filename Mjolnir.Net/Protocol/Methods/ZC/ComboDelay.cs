using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x01d2, size: 10, name: "ZC_COMBODELAY", direction: MethodAttribute.packetdirection.pd_in)]
    public class ComboDelay : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}
