﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x02b2, size: MethodAttribute.packet_length_dynamic, name: "ZC_ALL_QUEST_MISSION", direction: MethodAttribute.packetdirection.pd_in)]
    public class All_Quest_Mission : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}