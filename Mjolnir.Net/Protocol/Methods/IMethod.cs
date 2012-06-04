using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods
{
    public interface IMethod
    {
        void Parse(Header header, byte[] data);
    }
}
