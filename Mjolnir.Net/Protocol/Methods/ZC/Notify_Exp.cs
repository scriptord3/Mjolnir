using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x07f6, size: 14, name: "ZC_NOTIFY_EXP", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_Exp : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}