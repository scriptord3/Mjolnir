using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x00aa, size: 9, name: "ZC_REQ_WEAR_EQUIP_ACK", direction: MethodAttribute.packetdirection.pd_in)]
    public class Req_Wear_Equip_Ack : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}