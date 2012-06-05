using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x07e1, size: 15, name: "ZC_SKILLINFO_UPDATE2", direction: MethodAttribute.packetdirection.pd_in)]
    public class Skillinfo_Update2 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}
