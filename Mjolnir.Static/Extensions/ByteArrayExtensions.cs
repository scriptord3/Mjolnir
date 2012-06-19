using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Static.Extensions
{
    public static class ByteArrayExtensions
    {
        public static string NullByteTerminatedString(this byte[] byteArray)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < byteArray.Length; i++)
            {
                if (byteArray[i] == 0x00)
                    return str.ToString();
                else
                    str.Append(Convert.ToChar(byteArray[i]));
            }
            return str.ToString();
        }

        public static string ToHexString(this byte[] byteArray)
        {
            return byteArray.Aggregate("", (current, b) => current + b.ToString("X2"));
        }

        public static string ToHexString(this byte[] byteArray, int index, int length)
        {
            var temp = new byte[length];
            Array.Copy(byteArray, index, temp, 0, length);
            return temp.Aggregate("", (current, b) => current + b.ToString("X2") + " ");
        }

        private static void AppendLine(StringBuilder result, string str) { result.AppendLine(str); }
        private static char ToHexChar(byte b)
        {
            return (b >= 0x20 && b < 0x80) ? (char)b : '.';
        }

        public static string Hexdump(this byte[] buffer)
        {
            StringBuilder b = new StringBuilder();
            b.AppendLine();
            AppendLine(b, "[0x" + buffer.Length.ToString("X8") + "] {{");

            int length = Math.Min(buffer.Length, 0xFFFF);
            for (int i = 0; i < length; i += 16)
            {

                b.AppendFormat("  {0:X4}  ", i);
                for (int n = 0; n < 8; n++)
                {
                    int o = i + n;
                    if (o < length)
                        b.AppendFormat("{0:X2} ", buffer[o]);
                    else
                        b.Append("   ");
                }
                b.Append(" ");
                for (int n = 0; n < 8; n++)
                {
                    int o = i + n + 8;
                    if (o < length)
                        b.AppendFormat("{0:X2} ", buffer[o]);
                    else
                        b.Append("   ");
                }
                b.Append(" ");

                for (int n = 0; n < 8; n++)
                {
                    int o = i + n;
                    if (o < length)
                        b.AppendFormat("{0}", ToHexChar(buffer[o]));
                    else
                        b.Append(" ");
                }
                b.Append(" ");
                for (int n = 0; n < 8; n++)
                {
                    int o = i + n + 8;
                    if (o < length)
                        b.AppendFormat("{0}", ToHexChar(buffer[o]));
                    else
                        b.Append(" ");
                }
                b.AppendLine();
            }
            AppendLine(b, "}}");
            return b.ToString();
        }
    }
}
