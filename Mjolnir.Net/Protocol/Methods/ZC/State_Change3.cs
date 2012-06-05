using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0229, size: 15, name: "ZC_STATE_CHANGE3", direction: MethodAttribute.packetdirection.pd_in)]
    public class State_Change3 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}

