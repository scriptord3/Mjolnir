using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0080, size: 7, name: "ZC_NOTIFY_VANISH", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_Vanish : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}