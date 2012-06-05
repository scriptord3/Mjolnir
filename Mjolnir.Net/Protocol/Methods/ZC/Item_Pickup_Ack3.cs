using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x02d4, size: 29, name: "ZC_ITEM_PICKUP_ACK3", direction: MethodAttribute.packetdirection.pd_in)]
    public class Item_Pickup_Ack3 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}