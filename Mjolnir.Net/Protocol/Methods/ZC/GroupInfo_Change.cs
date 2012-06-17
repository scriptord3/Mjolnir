using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0101, size: 6, name: "ZC_GROUPINFO_CHANGE", direction: MethodAttribute.packetdirection.pd_in)]
    public class GroupInfo_Change : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}