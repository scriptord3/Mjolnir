using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0291, size: 4, name: "ZC_MSG", direction: MethodAttribute.packetdirection.pd_in)]
    public class Msg : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}