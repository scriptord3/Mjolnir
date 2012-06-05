using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x01de, size: 33, name: "ZC_NOTIFY_SKILL2", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_Skill2 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}