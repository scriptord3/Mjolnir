using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Static
{
    public static class Logging
    {
        public enum LogLevel
        {
            None,
            Error,
            Warning,
            Input,
            Info,
            Debug
        };

        public static void Trace(string message, LogLevel level, params object[] args)
        {
            switch (level)
            {
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case LogLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                case LogLevel.Input:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case LogLevel.Info:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case LogLevel.Debug:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
            }
            Console.WriteLine(message, args);
            Console.ResetColor();
        }
    }
}
