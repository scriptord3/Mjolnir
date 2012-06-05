
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol
{
    class PacketLengthMgr
    {
        public static int GetPacketLengthForMethodId(uint methodId)
        {
            return Net.Protocol.Methods.Method.GetSize(methodId); ;
        }
    }
}
