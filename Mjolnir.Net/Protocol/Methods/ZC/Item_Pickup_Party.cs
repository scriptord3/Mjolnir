using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x02b8, size: 22, name: "ZC_ITEM_PICKUP_PARTY", direction: MethodAttribute.packetdirection.pd_in)]
    public class Item_Pickup_Party : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}