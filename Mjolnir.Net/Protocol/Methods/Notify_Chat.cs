using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods
{
    [Method(methodId: 0x008d, size: MethodAttribute.packet_length_dynamic, name: "NOTIFY_CHAT")]
    class Notify_Chat : IMethod
    {
        public void Parse(Header header, byte[] data)
        {
            var id = (uint)((data[0] << 32) | (data[1] << 16) | (data[2] << 8) | data[3]);
        }
    }
}
