using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0087, size: 12, name: "ZC_NOTIFY_PLAYERMOVE", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_PlayerMove : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}