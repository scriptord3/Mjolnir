using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x01d7, size: 11, name: "ZC_SPRITE_CHANGE2", direction: MethodAttribute.packetdirection.pd_in)]
    public class Sprite_Change2 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}

