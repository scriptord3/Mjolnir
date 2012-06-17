using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Static.Extensions
{
    public static class ByteArrayExtensions
    {
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
    }
}
