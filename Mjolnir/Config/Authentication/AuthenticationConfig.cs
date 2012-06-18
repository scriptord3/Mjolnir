using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Config.Authentication
{
    public sealed class Config : Mjolnir.Config.Config
    {
        public string Username { get { return this.GetString("Username", String.Empty); } set { this.Set("Username", value); } }
        public string Password { get { return this.GetString("Password", String.Empty); } set { this.Set("Password", value); } }

        private static readonly Config _instance = new Config();
        public static Config Instance { get { return _instance; } }
        private Config() : base("Authentication") { }
    }
}
