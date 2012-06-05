using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0095, size: 30, name: "ZC_ACK_REQNAME", direction: MethodAttribute.packetdirection.pd_in)]
    public class Ack_ReqName : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}