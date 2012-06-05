using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0283, size: 6, name: "ZC_AID", direction: MethodAttribute.packetdirection.pd_in)]
    public class Aid : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}