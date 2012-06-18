using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using Mjolnir.Net;
using Mjolnir.Static;
using Mjolnir.Static.Extensions;

namespace Mjolnir
{
    class Program
    {
        private static Net.RoNetBuffer _buffer;
        private static System.Net.Sockets.Socket _socket;
        private static Queue<Net.Protocol.Methods.IMethodOut> _packetQueue;

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

            //using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            //{
            //    using (System.IO.BinaryWriter bw = new System.IO.BinaryWriter(ms))
            //    {
            //        login.WriteTo(bw);
            //    }
            //}

            string username = Config.Authentication.Config.Instance.Username;
            if (string.IsNullOrEmpty(username))
            {
                username = GetConsoleInput("Please enter the username.", ConsoleOutputType.Message, ConsoleInputReturnType.String);
                Config.Authentication.Config.Instance.Username = username;
                Config.Authentication.Config.Instance.Save();
            }

            string password = Config.Authentication.Config.Instance.Password.Decrypt("MjOlNiR2012");
            if (string.IsNullOrEmpty(password))
            {
                password = GetConsoleInput("Please enter the password.", ConsoleOutputType.Message, ConsoleInputReturnType.String);
                Config.Authentication.Config.Instance.Password = password.Encrypt("MjOlNiR2012");
                Config.Authentication.Config.Instance.Save();
            }

            Console.WriteLine("Select your server");
            string server = GetConsoleInput("aRO:iRO:fRO", ConsoleOutputType.List, ConsoleInputReturnType.String);

            _buffer = new Net.RoNetBuffer();
            Thread connecthread = new Thread(Connect);
            connecthread.Start();
            Thread parseThread = new Thread(Parse);
            parseThread.Start();

            _packetQueue = new Queue<Net.Protocol.Methods.IMethodOut>();
            _packetQueue.Enqueue(Net.Protocol.Methods.CA.Login.CreateBuilder()
                .SetVersion(20)
                .SetId(username.ToCharArray())
                .SetPasswd(password.ToCharArray())
                .SetClienttype(Static.ClientType.CLIENTTYPE_FRANCE)
                .Build());

            while (1 == 1)
            {
                Console.ReadLine();
            }
        }

        private static void Parse()
        {
            while (1 == 1)
            {
                while (_buffer.PacketAvaliable())
                {
                    var x = _buffer.GetPacketHeader();
                    if (x.Size == -2)
                        Console.Write("Header " + x.MethodId.ToString().PadLeft(5, Convert.ToChar(" ")) + ", 0x" + ((uint)x.MethodId).ToString("x4") + " ");
                    var d = _buffer.GetPacketData((int)x.Size);
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
                        m.Parse(x, d);
                    }
                    _buffer.Consume();
                }
                Thread.Sleep(0);
            }
        }

        private static void Sending()
        {
            while (_socket.Connected)
            {
                while (_packetQueue.Count > 0)
                {
                    Net.Protocol.Methods.IMethodOut p = _packetQueue.Dequeue();
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                    {
                        using (System.IO.BinaryWriter bw = new System.IO.BinaryWriter(ms))
                        {
                            p.WriteTo(bw);
                            Console.WriteLine(ms.ToArray().ToHexString());
                            _socket.Send(ms.ToArray());
                        }
                    }
                }
                Thread.Sleep(0);
            }
        }

        private static void Connect()
        {
            try
            {
                Byte[] byteRecv = new Byte[32769];
                int recvBytes = 0;

                _socket = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);
                try
                {
                    _socket.Connect("127.0.0.1", 6900);
                }
                catch (Exception ex)
                {
                    return;
                }

                Thread senderThread = new Thread(Sending);
                senderThread.Start();
                //m_ClientDisconnected = false;

                do
                {
                    while (_socket.Available == 0)
                    {
                        //if (m_ClientDisconnected)
                        //return;
                        //if (g_EvtStop.WaitOne(100))
                        //return;
                        //if (m_ClosedConnection.WaitOne(100))
                        //return;
                        Thread.Sleep(0);
                    }
                    recvBytes = _socket.Receive(byteRecv, System.Net.Sockets.SocketFlags.None);

                    if (recvBytes == 0)
                    {
                        break;
                    }

                    _buffer.Append(byteRecv, recvBytes);

                } while (true);
            }
            catch (Exception ex)
            {
            }
            finally
            {
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
