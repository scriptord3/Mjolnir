using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x043f, size: 25, name: "ZC_MSG_STATE_CHANGE2", direction: MethodAttribute.packetdirection.pd_in)]
    public class Msg_State_Change2 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}

