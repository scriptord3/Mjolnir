using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods
{
    public interface IMethodIn
    {
        void Parse(Header header, byte[] data);
    }

    public interface IMethodOut
    {
    }
}
