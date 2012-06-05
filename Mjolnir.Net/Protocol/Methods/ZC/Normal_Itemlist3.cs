using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x02e8, size: MethodAttribute.packet_length_dynamic, name: "ZC_NORMAL_ITEMLIST3", direction: MethodAttribute.packetdirection.pd_in)]
    public class Normal_Itemlist3 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}