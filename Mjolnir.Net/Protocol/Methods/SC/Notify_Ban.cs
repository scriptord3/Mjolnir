using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mjolnir.Static;

namespace Mjolnir.Net.Protocol.Methods.SC
{
    [Method(methodId: 0x0081, size: 3, name: "SC_NOTIFY_BAN", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_Ban : IMethodIn
    {
        private byte _reason;
        public byte Reason { get { return _reason; } }

        public void Parse(Header header, byte[] data)
        {
            _reason = data[0];
        }
    }
}
