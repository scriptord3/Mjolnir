using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x00b1, size: 8, name: "ZC_LONGPAR_CHANGE", direction: MethodAttribute.packetdirection.pd_in)]
    public class LongPar_Change : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}