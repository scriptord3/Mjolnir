using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x02ea, size: MethodAttribute.packet_length_dynamic, name: "ZC_STORE_NORMAL_ITEMLIST3", direction: MethodAttribute.packetdirection.pd_in)]
    public class Store_Normal_Itemlist3 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}