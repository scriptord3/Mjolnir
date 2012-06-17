using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x00fb, size: MethodAttribute.packet_length_dynamic, name: "ZC_GROUP_LIST", direction: MethodAttribute.packetdirection.pd_in)]
    public class Group_List : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}