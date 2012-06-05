using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x00b4, size: MethodAttribute.packet_length_dynamic, name: "ZC_SAY_DIALOG", direction: MethodAttribute.packetdirection.pd_in)]
    public class Say_Dialog : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}
