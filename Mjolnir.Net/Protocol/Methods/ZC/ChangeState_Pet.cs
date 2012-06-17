using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x01a4, size: 11, name: "ZC_CHANGESTATE_PET", direction: MethodAttribute.packetdirection.pd_in)]
    public class ChangeState_Pet : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}