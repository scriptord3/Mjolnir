using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0196, size: 9, name: "ZC_MSG_STATE_CHANGE", direction: MethodAttribute.packetdirection.pd_in)]
    public class Msg_State_Change : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}