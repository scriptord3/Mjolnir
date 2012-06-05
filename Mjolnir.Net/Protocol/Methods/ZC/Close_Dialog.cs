using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x00b6, size: 6, name: "ZC_CLOSE_DIALOG", direction: MethodAttribute.packetdirection.pd_in)]
    public class Close_Dialog : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}
