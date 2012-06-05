using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0446, size: 14, name: "ZC_QUEST_NOTIFY_EFFECT", direction: MethodAttribute.packetdirection.pd_in)]
    public class Quest_Notify_Effect : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}