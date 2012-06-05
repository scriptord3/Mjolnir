using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x008a, size: 29, name: "ZC_NOTIFY_ACT", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_Act : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}