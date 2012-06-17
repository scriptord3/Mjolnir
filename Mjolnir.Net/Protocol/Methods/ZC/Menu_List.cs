using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x00b7, size: MethodAttribute.packet_length_dynamic, name: "ZC_MENU_LIST", direction: MethodAttribute.packetdirection.pd_in)]
    public class Menu_List : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}