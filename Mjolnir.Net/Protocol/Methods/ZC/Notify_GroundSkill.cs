using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0117, size: 18, name: "ZC_NOTIFY_GROUNDSKILL", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_GroundSkill : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}