using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x00c0, size: 7, name: "ZC_EMOTION", direction: MethodAttribute.packetdirection.pd_in)]
    public class Emotion : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}