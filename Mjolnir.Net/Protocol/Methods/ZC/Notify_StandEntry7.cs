using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0857, size: MethodAttribute.packet_length_dynamic, name: "ZC_NOTIFY_STANDENTRY7", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_StandEntry7 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}