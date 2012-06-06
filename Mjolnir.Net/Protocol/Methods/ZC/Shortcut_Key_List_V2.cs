using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x07d9, size: 268, name: "ZC_SHORTCUT_KEY_LIST_V2", direction: MethodAttribute.packetdirection.pd_in)]
    public class Shortcut_Key_List_V2 : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}