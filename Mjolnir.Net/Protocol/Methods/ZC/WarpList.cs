using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x011c, size: 68, name: "ZC_WARPLIST", direction: MethodAttribute.packetdirection.pd_in)]
    public class WarpList : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}