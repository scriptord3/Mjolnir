using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x00f2, size: 6, name: "ZC_NOTIFY_STOREITEM_COUNTINFO", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_Storeitem_Countinfo : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}