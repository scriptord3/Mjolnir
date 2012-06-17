using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x08c7, size: MethodAttribute.packet_length_dynamic, name: "ZC_SKILL_ENTRY3", direction: MethodAttribute.packetdirection.pd_in)]
    public class Skill_Entry3 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}