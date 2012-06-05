using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x00ac, size: 7, name: "ZC_REQ_TAKEOFF_EQUIP_ACK", direction: MethodAttribute.packetdirection.pd_in)]
    public class Req_TakeOff_Equip_Ack : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}