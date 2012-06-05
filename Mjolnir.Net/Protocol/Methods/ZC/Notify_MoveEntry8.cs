using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0856, size: MethodAttribute.packet_length_dynamic, name: "ZC_NOTIFY_MOVEENTRY8", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_MoveEntry8 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}