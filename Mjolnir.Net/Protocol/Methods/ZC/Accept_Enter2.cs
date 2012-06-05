using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x02eb, size: 13, name: "ZC_ACCEPT_ENTER2", direction: MethodAttribute.packetdirection.pd_in)]
    public class Accept_Enter2 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}