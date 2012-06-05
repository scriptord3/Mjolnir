using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.CC
{
    [Method(methodId: 0x08ae, size: MethodAttribute.packet_length_dynamic, name: "CC_REPLAYPACKET", direction: MethodAttribute.packetdirection.pd_in)]
    public class ReplayPacket : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}
