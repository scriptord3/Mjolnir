using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x090f, size: MethodAttribute.packet_length_dynamic, name: "ZC_NOTIFY_NEWENTRY7", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_NewEntry7 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}