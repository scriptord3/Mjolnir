using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.AC
{
    [Method(methodId: 0x0069, size: MethodAttribute.packet_length_dynamic, name: "AC_ACCEPT_LOGIN", direction: MethodAttribute.packetdirection.pd_in)]
    public class Accept_Login : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}
