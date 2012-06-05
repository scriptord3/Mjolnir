using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0195, size: 102, name: "ZC_ACK_REQNAMEALL", direction: MethodAttribute.packetdirection.pd_in)]
    public class Ack_ReqNameAll : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}