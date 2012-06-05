using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x010f, size: MethodAttribute.packet_length_dynamic, name: "ZC_SKILLINFO_LIST", direction: MethodAttribute.packetdirection.pd_in)]
    public class Skillinfo_List : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}
