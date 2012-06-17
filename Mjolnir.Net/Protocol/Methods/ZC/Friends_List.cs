using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0201, size: MethodAttribute.packet_length_dynamic, name: "ZC_FRIENDS_LIST", direction: MethodAttribute.packetdirection.pd_in)]
    public class Friends_List : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}