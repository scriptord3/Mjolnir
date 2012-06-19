using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mjolnir.Static.Extensions;

namespace Mjolnir.Net.Protocol.Methods.SC
{
    [Method(methodId: 0x006a, size: 23, name: "AC_REFUSE_LOGIN", direction: MethodAttribute.packetdirection.pd_in)]
    public class Refuse_Login : IMethodIn
    {
        private byte _errorCode;
        public byte ErrorCode { get { return _errorCode; } }

        private string _blockDate;
        public string BlockDate { get { return _blockDate; } }

        public void Parse(Header header, byte[] data)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(data))
            {
                using (System.IO.BinaryReader br = new System.IO.BinaryReader(ms))
                {
                    _errorCode = br.ReadByte();
                    _blockDate = br.ReadBytes(20).NullByteTerminatedString();
                }
            }
        }
    }
}