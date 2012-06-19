using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mjolnir.Static;

namespace Mjolnir.Net.Protocol.Methods.SC
{
    [Method(methodId: 0x0081, size: 3, name: "SC_NOTIFY_ERROR", direction: MethodAttribute.packetdirection.pd_in)]
    public class Notify_Error : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
            switch ((Mjolnir.Static.NotifyErrorResult)data[0])
            {
                case Mjolnir.Static.NotifyErrorResult.BAN_INFORMATION_REMAINED:
                    
                    Logging.Trace("The server still recognizes your old login", Logging.LogLevel.Warning);
                    break;
            }
        }
    }
}
