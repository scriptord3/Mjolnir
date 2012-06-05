using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x009a, size: MethodAttribute.packet_length_dynamic, name: "ZC_BROADCAST", direction: MethodAttribute.packetdirection.pd_in)]
    public class Broadcast : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}
