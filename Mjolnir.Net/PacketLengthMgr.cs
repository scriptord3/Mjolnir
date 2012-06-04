
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
            // packet got the length included
            Net.Protocol.Methods.Method.GetByID(methodId);
            Net.Protocol.Methods.Method.GetSize(methodId);
            return -1;
        }
    }
}
