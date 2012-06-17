using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x009c, size: 9, name: "ZC_CHANGE_DIRECTION", direction: MethodAttribute.packetdirection.pd_in)]
    public class Change_Direction : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}