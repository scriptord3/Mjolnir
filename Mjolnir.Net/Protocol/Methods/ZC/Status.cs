using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x00bd, size: 44, name: "ZC_STATUS", direction: MethodAttribute.packetdirection.pd_in)]
    public class Status : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}