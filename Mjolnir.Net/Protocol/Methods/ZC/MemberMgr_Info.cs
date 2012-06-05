using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0154, size: MethodAttribute.packet_length_dynamic, name: "ZC_MEMBERMGR_INFO", direction: MethodAttribute.packetdirection.pd_in)]
    public class MemberMgr_Info : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}