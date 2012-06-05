using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x02e7, size: MethodAttribute.packet_length_dynamic, name: "ZC_MAPPROPERTY", direction: MethodAttribute.packetdirection.pd_in)]
    public class MapProperty : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}

