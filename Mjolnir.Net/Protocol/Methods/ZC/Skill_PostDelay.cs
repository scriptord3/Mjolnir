using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x043d, size: 8, name: "ZC_SKILL_POSTDELAY", direction: MethodAttribute.packetdirection.pd_in)]
    public class Skill_PostDelay : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}