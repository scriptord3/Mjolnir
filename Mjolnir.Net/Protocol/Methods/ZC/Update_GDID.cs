using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x016c, size: 43, name: "ZC_UPDATE_GDID", direction: MethodAttribute.packetdirection.pd_in)]
    public class Update_GDID : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}