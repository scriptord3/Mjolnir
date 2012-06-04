using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x008d, size: MethodAttribute.packet_length_dynamic, name: "ZC_NOTIFY_CHAT", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_Chat : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
            var id = (uint)((data[0] << 32) | (data[1] << 16) | (data[2] << 8) | data[3]);
        }
    }
}
