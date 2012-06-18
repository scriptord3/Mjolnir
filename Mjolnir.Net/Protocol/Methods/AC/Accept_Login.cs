using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mjolnir.Static.Extensions;

namespace Mjolnir.Net.Protocol.Methods.AC
{
    [Method(methodId: 0x0069, size: MethodAttribute.packet_length_dynamic, name: "AC_ACCEPT_LOGIN", direction: MethodAttribute.packetdirection.pd_in)]
    public class Accept_Login : IMethodIn
    {
        private int _authCode;
        public int AuthCode { get { return _authCode; } }

        private uint _accountId;
        public uint AccountId { get { return _accountId; } }

        private uint _userLevel;
        public uint UserLevel { get { return _userLevel; } }

        private uint _lastLoginIP;
        public uint LastLoginIP { get { return _lastLoginIP; } }

        private byte[] _lastLoginTime;
        public byte[] LastLoginTime { get { return _lastLoginTime; } }
        
        private byte _sex;
        public byte Sex { get { return _sex; } }

        public void Parse(Header header, byte[] data)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(data))
            {
                using (System.IO.BinaryReader br = new System.IO.BinaryReader(ms))
                {
                    _authCode = br.ReadInt32();
                    _accountId = br.ReadUInt32();
                    _userLevel = br.ReadUInt32();
                    _lastLoginIP = br.ReadUInt32();
                    _lastLoginTime = br.ReadBytes(26);
                    _sex = br.ReadByte();

                    for (int i = (int)ms.Position; i < header.Size; i += 32)
                    {
                        string ip = string.Format("{0}.{1}.{2}.{3}", br.ReadByte(), br.ReadByte(), br.ReadByte(), br.ReadByte());
                        int port = br.ReadInt16();
                        string name = br.ReadBytes(22).NullByteTerminatedString();
                        int type = br.ReadInt16();
                        int cnt = br.ReadInt16();
                    }
                }
            }
        }
    }
}
