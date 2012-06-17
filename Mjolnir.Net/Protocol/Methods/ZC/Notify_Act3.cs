using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x08c8, size: 34, name: "ZC_NOTIFY_ACT3", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_Act3 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}