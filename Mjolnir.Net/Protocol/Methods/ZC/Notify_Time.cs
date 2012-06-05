using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x007f, size: 6, name: "ZC_NOTIFY_TIME", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_Time : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}
