using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x00b0, size: 8, name: "ZC_PAR_CHANGE", direction: MethodAttribute.packetdirection.pd_in)]
    public class Par_Change : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}
