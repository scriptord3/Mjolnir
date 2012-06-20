using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.IO;
using System.Reflection;
using Mjolnir.Net;
using Mjolnir.Static;
using Mjolnir.Static.Extensions;
using Nini.Ini;

namespace Mjolnir
{
    class Program
    {
        private static Net.RoNetBuffer _buffer;
        private static System.Net.Sockets.Socket _socket;
        private static Queue<Net.Protocol.Methods.IMethodOut> _packetQueue;
        private static Service _currentService;
        private static Thread _connectThread;

        private static ClientState _clientState;

        private const string PasswordEncryptionKey = "MjOlNiR2012";

        static void Main(string[] args)
        {
            StartConnect();

            while (1 == 1)
            {
                // loop until we are ingame
                while (_clientState != ClientState.ConnectedToZoneServer)// || _clientState == ClientState.Disconnected)
                {
                    Thread.Sleep(0);
                }

                string command = Console.ReadLine();
                switch (command)
                {
                    case "relog":
                        Relog(3);
                        break;
                    default:
                        Logging.Trace("Unknown command {0}", Logging.LogLevel.Warning, command);
                        break;
                }
            }
        }

        private static void StartConnect()
        {
            // reading the servers.ini for server configuration
            var ConfigFile = string.Format("{0}/{1}", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Data\\servers.ini"); // the config file's location.
            var Parser = new IniDocument(ConfigFile);
            Dictionary<string, Service> serviceList = new Dictionary<string, Service>();
            foreach (DictionaryEntry de in Parser.Sections)
            {
                IniSection section = (IniSection)de.Value;
                Service s = new Service();
                s.Name = de.Key.ToString();
                s.IP = section.GetValue("ip");
                s.Port = Convert.ToInt32(section.GetValue("port"));
                s.PasswordEncrypt = Convert.ToBoolean(section.GetValue("passwordencrypt"));
                serviceList.Add(de.Key.ToString(), s);
            }

            // if config.ini contains a valid server skip choosing a new one
            string service = Config.Server.Config.Instance.Name;
            if (string.IsNullOrEmpty(service) || !serviceList.ContainsKey(service))
            {
                var selectedService = ConsoleHelper.GetConsoleMenu<Service>("Select your service", serviceList);
                _currentService = selectedService;
                Config.Server.Config.Instance.Name = selectedService.Name;
                Config.Server.Config.Instance.Save();
            }
            else
            {
                _currentService = serviceList[service];
            }

            // if config.ini contains a username skip asking for a new one
            string username = Config.Authentication.Config.Instance.Username;
            if (string.IsNullOrEmpty(username))
            {
                username = ConsoleHelper.GetConsoleString("Please enter the username");
                Config.Authentication.Config.Instance.Username = username;
                Config.Authentication.Config.Instance.Save();
            }

            // if config.ini contains a password skip asking for a new one
            string password = Config.Authentication.Config.Instance.Password;
            if (string.IsNullOrEmpty(password))
            {
                password = ConsoleHelper.GetConsoleString("Please enter the password");
                Config.Authentication.Config.Instance.Password = password.Encrypt(PasswordEncryptionKey);
                Config.Authentication.Config.Instance.Save();
            }
            else
            {
                // decrypting password
                password = password.Decrypt(PasswordEncryptionKey);
            }

            // creating login packet and enqueue so it will get sent once we are connected
            // might change this later to support password_encrypt from clientinfo.xml
            _packetQueue = new Queue<Net.Protocol.Methods.IMethodOut>();
            _packetQueue.Enqueue(Net.Protocol.Methods.CA.Login.CreateBuilder()
                .SetVersion(20)
                .SetId(username.ToCharArray())
                .SetPasswd(password.ToCharArray())
                .SetClienttype(Static.ClientType.CLIENTTYPE_FRANCE)
                .Build());

            // creating the buffer for the ragnarok packets
            _buffer = new Net.RoNetBuffer();

            // start connection
            _connectThread = new Thread(Connect);
            _connectThread.Start();
        }

        private static void Relog(int seconds = 5)
        {
            Logging.Trace("Relogging in {0} seconds", Logging.LogLevel.Info, seconds);
            if (_socket != null) _socket.Close();
            Thread.Sleep(seconds * 1000);

            StartConnect();
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
                    Logging.Trace("Connecting to {0}:{1}", Logging.LogLevel.Info, _currentService.IP, _currentService.Port);
                    _socket.Connect(_currentService.IP, _currentService.Port);
                }
                catch
                {
                    Logging.Trace("Could not connect to server. Type 'relog' to reconnect.", Logging.LogLevel.Error);
                    return;
                }
                Logging.Trace("Connected.", Logging.LogLevel.Debug);

                Thread senderThread = new Thread(Sending);
                senderThread.Start();

                Thread parseThread = new Thread(ParsePackets);
                parseThread.Start();

                do
                {
                    while (_socket.Available == 0)
                        Thread.Sleep(0);

                    recvBytes = _socket.Receive(byteRecv, System.Net.Sockets.SocketFlags.None);

                    if (recvBytes == 0)
                        break;

                    _buffer.Append(byteRecv, recvBytes);

                } while (true);
            }
            catch
            {
            }
            finally
            {
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
                            Logging.Trace(ms.ToArray().Hexdump(), Logging.LogLevel.Debug);
                            _socket.Send(ms.ToArray());
                        }
                    }
                }
                Thread.Sleep(0);
            }
        }

        // packet parsing
        private static void ParsePackets()
        {
            while (_socket.Connected)
            {
                while (_buffer.PacketAvaliable())
                {
                    var x = _buffer.GetPacketHeader();
                    if (x.Size == -2)
                    {
                        Logging.Trace("Unknown Packet received 0x{0:x4} ({0})", Logging.LogLevel.Error, x.MethodId);
                        _buffer.Clear();
                        break;
                    }

                    var d = _buffer.GetPacketData((int)x.Size);
                    var m = Net.Protocol.Methods.Method.GetByID(x.MethodId);

                    if (m != null)
                    {
                        Logging.Trace(m.GetType().Name, Logging.LogLevel.Debug);
                        Logging.Trace(d.Hexdump(), Logging.LogLevel.Debug);
                        m.Parse(x, d);
                        switch (x.MethodId)
                        {
                            case (uint)PacketHeader.HEADER_SC_NOTIFY_BAN:
                                {
                                    Mjolnir.Net.Protocol.Methods.SC.Notify_Ban p = (Mjolnir.Net.Protocol.Methods.SC.Notify_Ban)m;
                                    switch ((NotifyErrorResult)p.Reason)
                                    {
                                        case NotifyErrorResult.BAN_INFORMATION_REMAINED:
                                            Logging.Trace("The server still recognizes your old login", Logging.LogLevel.Warning);
                                            Relog(5);
                                            break;
                                    }
                                }
                                break;

                            case (uint)PacketHeader.HEADER_AC_ACCEPT_LOGIN:
                                {
                                    Mjolnir.Net.Protocol.Methods.AC.Accept_Login p = (Mjolnir.Net.Protocol.Methods.AC.Accept_Login)m;
                                    Server res = ConsoleHelper.GetConsoleMenu<Server>("Select your Server", p.ServerList);
                                    Logging.Trace("Selected {0}", Logging.LogLevel.Warning, res.Name);
                                }
                                break;
                        }
                    }
                    _buffer.Consume();
                }
                Thread.Sleep(0);
            }
        }
    }
}
