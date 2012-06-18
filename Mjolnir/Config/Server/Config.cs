using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Config.Server
{
    public sealed class Config : Mjolnir.Config.Config
    {
        public string IP { get { return this.GetString("IP", String.Empty); } set { this.Set("IP", value); } }
        public int Port { get { return this.GetInt("Port", 0); } set { this.Set("Port", value); } }

        private static readonly Config _instance = new Config();
        public static Config Instance { get { return _instance; } }
        private Config() : base("Server") { }
    }
}
