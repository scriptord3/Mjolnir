using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Static
{
    public class Service
    {
        private Dictionary<string, string> _settings;

        public string Name { get { return _settings["name"]; } set { _settings["name"] = value; } }
        public string IP { get { return _settings["ip"]; } set { _settings["ip"] = value; } }
        public int Port { get { return Convert.ToInt32(_settings["port"]); } set { _settings["port"] = value.ToString(); } }

        public Service()
        {
            _settings = new Dictionary<string,string>();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
