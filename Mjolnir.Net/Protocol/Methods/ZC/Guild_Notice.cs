using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x016f, size: 182, name: "ZC_GUILD_NOTICE", direction: MethodAttribute.packetdirection.pd_in)]
    public class Guild_Notice : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}

