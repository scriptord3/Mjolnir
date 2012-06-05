using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0166, size: MethodAttribute.packet_length_dynamic, name: "ZC_POSITION_ID_NAME_INFO", direction: MethodAttribute.packetdirection.pd_in)]
    public class Position_Id_Name_Info : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}