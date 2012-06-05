using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0206, size: 11, name: "ZC_FRIENDS_STATE", direction: MethodAttribute.packetdirection.pd_in)]
    public class Friends_State : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}
