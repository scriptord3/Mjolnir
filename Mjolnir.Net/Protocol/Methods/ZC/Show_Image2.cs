using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x01b3, size: 67, name: "ZC_SHOW_IMAGE2", direction: MethodAttribute.packetdirection.pd_in)]
    public class Show_Image2 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}
