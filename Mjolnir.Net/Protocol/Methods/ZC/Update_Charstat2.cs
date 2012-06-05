using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x01f2, size: 20, name: "ZC_UPDATE_CHARSTAT2", direction: MethodAttribute.packetdirection.pd_in)]
    public class Update_Charstat2 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}
