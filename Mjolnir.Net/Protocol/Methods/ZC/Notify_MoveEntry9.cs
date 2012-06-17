using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0914, size: MethodAttribute.packet_length_dynamic, name: "ZC_NOTIFY_MOVEENTRY9", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_MoveEntry9 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}