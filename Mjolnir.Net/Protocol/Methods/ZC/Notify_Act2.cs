using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x02e1, size: 33, name: "ZC_NOTIFY_ACT2", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_Act2 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}