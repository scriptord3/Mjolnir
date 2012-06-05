using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x00a1, size: 6, name: "ZC_ITEM_DISAPPEAR", direction: MethodAttribute.packetdirection.pd_in)]
    public class Item_Disappear : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}