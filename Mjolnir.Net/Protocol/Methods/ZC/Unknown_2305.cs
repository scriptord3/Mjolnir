using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0901, size: MethodAttribute.packet_length_dynamic, name: "ZC_UNKNOWN_2305", direction: MethodAttribute.packetdirection.pd_in)]
    public class Unknown_2305 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}