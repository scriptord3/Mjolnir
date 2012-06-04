using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir
{
    class Program
    {
        static void Main(string[] args)
       {
           var xy = Net.Protocol.Methods.Method.GetByID(0x008d);
           var xyz = Net.Protocol.Methods.Method.GetSize(0x008d);
            Net.RoNetBuffer buffer = new Net.RoNetBuffer();
            // '008D' => ['public_chat', 'v a4 Z*', [qw(len ID message)]],
            byte[] test;// { 0x00, 0x8d, 0x00, 0x0a, 0x00, 0x00, 0x00, 0x01, 0x34, 0x36 };

            using (var x = System.IO.File.Open("D:\\Dropbox\\RagnarokCaptureReplay\\rrf\\bin\\a.bin", System.IO.FileMode.Open))
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
                m.Parse(x, d);
            }
        }
    }
}
