using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0088, size: 10, name: "ZC_STOPMOVE", direction: MethodAttribute.packetdirection.pd_in)]
    public class StopMove : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}