using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Static
{
    public class Server
    {
        private Dictionary<string, string> _settings;

        public string Name { get { return _settings["name"]; } set { _settings["name"] = value; } }
        public string IP { get { return _settings["ip"]; } set { _settings["ip"] = value; } }
        public int Port { get { return Convert.ToInt32(_settings["port"]); } set { _settings["port"] = value.ToString(); } }
        public int Type { get { return Convert.ToInt32(_settings["type"]); } set { _settings["type"] = value.ToString(); } }
        public int UserCount { get { return Convert.ToInt32(_settings["cnt"]); } set { _settings["cnt"] = value.ToString(); } }

        public Server()
        {
            _settings = new Dictionary<string, string>();
        }

        public override string ToString()
        {
            return String.Format("{0} ({1})", Name.PadRight(22), UserCount);
        }
    }
}
