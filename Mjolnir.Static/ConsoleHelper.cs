using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Static
{
    public static class ConsoleHelper
    {
        public static string GetConsoleString(string message)
        {
            Logging.Trace(message, Logging.LogLevel.Input);
            string input = Console.ReadLine();
            return input;
        }

        public static T GetConsoleMenu<T>(string message, Dictionary<string, T> list)
        {
            int index = 1;
            foreach (var x in list)
            {
                Logging.Trace("{0}. {1}", Logging.LogLevel.Input, index, x.Value.ToString());
                index++;
            }

            int selected = 0;
            while (selected < 1 || selected > list.Count())
            {
                Logging.Trace(message, Logging.LogLevel.Input);
                string input = Console.ReadLine();
                int.TryParse(input, out selected);
            }

            return list.Values.ElementAt(selected - 1);
        }
    }
}
