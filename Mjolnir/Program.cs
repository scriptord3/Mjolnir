using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mjolnir.Net;
using Mjolnir.Static;
using Mjolnir.Static.Extensions;
namespace Mjolnir
{
    class Program
    {
        static void Main(string[] args)
        {
            //var xy = Net.Protocol.Methods.Method.GetByID(0x008d);
            //var xyz = Net.Protocol.Methods.Method.GetSize(0x008d);

            //struct PACKET_CA_LOGIN {
            //  /* this+0x0 */ short PacketType
            //  /* this+0x2 */ unsigned long Version
            //  /* this+0x6 */ unsigned char[0x18] ID
            //  /* this+0x1e */ unsigned char[0x18] Passwd
            //  /* this+0x36 */ unsigned char clienttype
            //}
            //var login = Net.Protocol.Methods.CA.Login.CreateBuilder()
            //    .SetVersion(20)
            //    .SetId("Scriptor".ToCharArray())
            //    .SetPasswd("PaSsWoRt".ToCharArray())
            //    .SetClienttype(Static.ClientType.CLIENTTYPE_FRANCE)
            //    .Build();

            //using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            //{
            //    using (System.IO.BinaryWriter bw = new System.IO.BinaryWriter(ms))
            //    {
            //        login.WriteTo(bw);
            //    }
            //}

            var username = GetConsoleInput("Please enter the username.", ConsoleOutputType.Message, ConsoleInputReturnType.String);
            var password = GetConsoleInput("Please enter the password.", ConsoleOutputType.Message, ConsoleInputReturnType.String);
            Console.WriteLine("Select your server");
            var server = GetConsoleInput("aRO:iRO:fRO", ConsoleOutputType.List, ConsoleInputReturnType.String);
            Net.RoNetBuffer buffer = new Net.RoNetBuffer();
            byte[] test;
            using (var x = System.IO.File.Open("paradise.bot", System.IO.FileMode.Open))
            {
                test = new byte[(int)x.Length];
                x.Read(test, 0, (int)x.Length);
            }
            buffer.Append(test);

            Console.WriteLine("Packet Parsers: " + Mjolnir.Net.Protocol.Methods.Method.Count());
            while (buffer.PacketAvaliable())
            {
                var x = buffer.GetPacketHeader();
                if (x.Size == -2)
                    Console.Write("Header " + x.MethodId.ToString().PadLeft(5, Convert.ToChar(" ")) + ", 0x" + ((uint)x.MethodId).ToString("x4") + " ");
                var d = buffer.GetPacketData((int)x.Size);
                var m = Net.Protocol.Methods.Method.GetByID(x.MethodId);

                if (m == null)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("unknown!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("parsed ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(m.GetType().Name);
                    Console.ResetColor();
                }
                //m.Parse(x, d);
                buffer.Consume();
            }
        }

        enum ConsoleInputReturnType
        {
            String,
            Char
        }

        enum ConsoleOutputType
        {
            Message,
            List
        }

        static string GetConsoleInput(string message, ConsoleOutputType outputType, ConsoleInputReturnType returnType)
        {
            Dictionary<int, string> optionList = new Dictionary<int, string>();
            switch (outputType)
            {
                case ConsoleOutputType.Message:
                    Console.WriteLine(message);
                    break;

                case ConsoleOutputType.List:
                    int index = 0;
                    foreach (string option in message.Split(Convert.ToChar(":")))
                    {
                        optionList.Add(index, option);
                        Console.WriteLine("{0}. {1}", index, option);
                        index++;
                    }
                    break;
            }

            switch (returnType)
            {
                case ConsoleInputReturnType.String:
                    {
                        var input = Console.ReadLine();
                        return input;
                    }

                case ConsoleInputReturnType.Char:
                    {
                        string input = Console.ReadKey().ToString();
                        if (outputType == ConsoleOutputType.List)
                        {
                            int selectedIndex = -1;
                            if (int.TryParse(input, out selectedIndex))
                            {
                                if (optionList.ContainsKey(selectedIndex))
                                {
                                    return optionList[selectedIndex];
                                }
                                else
                                {
                                    Console.WriteLine("Invalid selection");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid selection");
                            }
                        }
                        return input;
                    }
            }
            return string.Empty;
        }
    }
}
