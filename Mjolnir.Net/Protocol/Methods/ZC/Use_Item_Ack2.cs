using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x01c8, size: 13, name: "ZC_USE_ITEM_ACK2", direction: MethodAttribute.packetdirection.pd_in)]
    public class Use_Item_Ack2 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}