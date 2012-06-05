using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0147, size: 39, name: "ZC_AUTORUN_SKILL", direction: MethodAttribute.packetdirection.pd_in)]
    public class AutoRun_Skill : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}