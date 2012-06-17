using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x00d8, size: 6, name: "ZC_DESTROY_ROOM", direction: MethodAttribute.packetdirection.pd_in)]
    public class Destroy_Room : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}