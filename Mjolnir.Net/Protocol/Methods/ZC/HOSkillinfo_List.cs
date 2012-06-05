using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0235, size: MethodAttribute.packet_length_dynamic, name: "ZC_HOSKILLINFO_LIST", direction: MethodAttribute.packetdirection.pd_in)]
    public class HOSkillinfo_List : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}
