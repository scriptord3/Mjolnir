using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Config.Server
{
    public sealed class Config : Mjolnir.Config.Config
    {
        public string Name { get { return this.GetString("Name", string.Empty); } set { this.Set("Name", value); } }

        private static readonly Config _instance = new Config();
        public static Config Instance { get { return _instance; } }
        private Config() : base("Server") { }
    }
}
