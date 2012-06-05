using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x01d6, size: 4, name: "ZC_NOTIFY_MAPPROPERTY2", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_MapProperty2 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}

