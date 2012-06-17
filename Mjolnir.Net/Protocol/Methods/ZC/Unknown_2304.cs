using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0900, size: MethodAttribute.packet_length_dynamic, name: "ZC_UNKNOWN_2304", direction: MethodAttribute.packetdirection.pd_in)]
    public class Unknown_2304 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}