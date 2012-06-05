using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x01f3, size: 10, name: "ZC_NOTIFY_EFFECT2", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_Effect2 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}