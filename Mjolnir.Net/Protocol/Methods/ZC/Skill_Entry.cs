using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x011f, size: 16, name: "ZC_SKILL_ENTRY", direction: MethodAttribute.packetdirection.pd_in)]
    public class Skill_Entry : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}