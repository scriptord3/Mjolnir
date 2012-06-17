using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x02da, size: 3, name: "ZC_CONFIG_NOTIFY", direction: MethodAttribute.packetdirection.pd_in)]
    public class Config_Notify : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}