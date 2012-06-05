using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x01e9, size: 81, name: "ZC_ADD_MEMBER_TO_GROUP2", direction: MethodAttribute.packetdirection.pd_in)]
    public class Add_Member_To_Group2 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}