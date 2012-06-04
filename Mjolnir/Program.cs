using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mjolnir.Net;
using Mjolnir.Static;

namespace Mjolnir
{
    class Program
    {
        static void Main(string[] args)
        {
            var xy = Net.Protocol.Methods.Method.GetByID(0x008d);
            var xyz = Net.Protocol.Methods.Method.GetSize(0x008d);

            //struct PACKET_CA_LOGIN {
            //  /* this+0x0 */ short PacketType
            //  /* this+0x2 */ unsigned long Version
            //  /* this+0x6 */ unsigned char[0x18] ID
            //  /* this+0x1e */ unsigned char[0x18] Passwd
            //  /* this+0x36 */ unsigned char clienttype
            //}
            var login = Net.Protocol.Methods.CA.Login.CreateBuilder()
                .SetVersion(20)
                .SetId("Scriptor".ToCharArray())
                .SetPasswd("PaSsWoRt".ToCharArray())
                .SetClienttype(Static.ClientType.CLIENTTYPE_FRANCE)
                .Build();

            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                using (System.IO.BinaryWriter bw = new System.IO.BinaryWriter(ms))
                {
                    login.WriteTo(bw);
                }
            }
            Net.RoNetBuffer buffer = new Net.RoNetBuffer();
            // '008D' => ['public_chat', 'v a4 Z*', [qw(len ID message)]],
            byte[] test;// { 0x00, 0x8d, 0x00, 0x0a, 0x00, 0x00, 0x00, 0x01, 0x34, 0x36 };

            using (var x = System.IO.File.Open("6258.bin", System.IO.FileMode.Open))
            {
                test = new byte[(int)x.Length];
                x.Read(test, 0, (int)x.Length);
            }
            buffer.Append(test);
            while (buffer.PacketAvaliable())
            {
                var x = buffer.GetPacketHeader();
                var d = buffer.GetPacketData((int)x.Size);
                var m = Net.Protocol.Methods.Method.GetByID(x.MethodId);
                if (m == null)
                    Console.WriteLine("Unknown method 0x" + ((uint)x.MethodId).ToString("x4") + "!");
                else
                    m.Parse(x, d);
                buffer.Consume();
            }
        }
    }
}
