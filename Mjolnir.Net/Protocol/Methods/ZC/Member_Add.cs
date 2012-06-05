using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0182, size: 106, name: "ZC_MEMBER_ADD", direction: MethodAttribute.packetdirection.pd_in)]
    public class Member_Add : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}
