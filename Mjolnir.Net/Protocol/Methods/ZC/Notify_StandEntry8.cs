using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0915, size: MethodAttribute.packet_length_dynamic, name: "ZC_NOTIFY_STANDENTRY8", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_StandEntry8 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}