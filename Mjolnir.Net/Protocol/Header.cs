using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol
{
    public class Header
    {
        private uint _methodId;
        public uint MethodId
        {
            get { return _methodId; }
            set { _methodId = value; }
        }

        private int _headerSize;
        public int HeaderSize
        {
            get { return _headerSize; }
            set { _headerSize = value; }
        }

        private int _size;
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
         
        public static Header ParseFrom(byte[] data)
        {
            Header header = new Header();
            header.MethodId = (uint)((data[0] << 8) | data[1]);
            header.HeaderSize += 2;

            int size = Protocol.PacketLengthMgr.GetPacketLengthForMethodId(header.MethodId);
            if (size == -1)
            { 
                header.Size = ((data[2] << 8) | data[3]);
                header.HeaderSize += 2;
            }

            header.Size -= header.HeaderSize;
            return header;
        }
    }
}
