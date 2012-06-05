using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x009e, size: 17, name: "ZC_ITEM_FALL_ENTRY", direction: MethodAttribute.packetdirection.pd_in)]
    public class Item_Fall_Entry : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}