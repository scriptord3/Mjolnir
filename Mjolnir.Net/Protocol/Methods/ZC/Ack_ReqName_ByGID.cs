using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0194, size: 30, name: "ZC_ACK_REQNAME_BYGID", direction: MethodAttribute.packetdirection.pd_in)]
    public class Ack_ReqName_ByGID : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}