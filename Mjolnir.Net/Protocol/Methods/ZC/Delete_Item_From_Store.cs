using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x00f6, size: 8, name: "ZC_DELETE_ITEM_FROM_STORE", direction: MethodAttribute.packetdirection.pd_in)]
    public class Delete_Item_From_Store : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}