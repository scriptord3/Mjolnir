using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x013d, size: 6, name: "ZC_RECOVERY", direction: MethodAttribute.packetdirection.pd_in)]
    public class Recovery : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}