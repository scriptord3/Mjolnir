using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net
{
    public class RoNetBuffer
    {
        public int Position { get; private set; }

        public int Length
        {
            get { return _length - Position; }
        }

        private byte[] _data = new byte[0];
        private int _length = 0;

        public RoNetBuffer()
        {
            this.Position = 0;
        }

        public bool PacketAvaliable()
        {
            if (Length < 2)
                return false;

            Protocol.Header header = Protocol.Header.ParseFrom(_data);
            if (Length < header.HeaderSize + header.Size)
                return false;
            
            return true;
        }

        public Protocol.Header GetPacketHeader()
        {
            if (Length < 2)
                throw new Exception("GetPacketHeader when insuficient data avaliable");
            
            Protocol.Header header = Protocol.Header.ParseFrom(_data);
            Position += header.HeaderSize;

            return header;
        }

        public byte[] GetPacketData(int count)
        {
            if (Length < count)
                throw new Exception("GetPacketData called when insuficient data avaliable!");

            var tempData = new byte[count];
            Array.Copy(_data, Position, tempData, 0, count);

            Position += count;
            return tempData;
        }

        public void Consume()
        {
            Array.Copy(_data, Position, _data, 0, Length);

            _length = _length - Position;
            Position = 0;
        }

        public void Append(byte[] newdata)
        {
            if (_data.Length < _length + newdata.Length)
                Array.Resize(ref _data, _length + newdata.Length);

            Array.Copy(newdata, 0, _data, _length, newdata.Length);
            _length = _length + newdata.Length;
        }

        public void Append(byte[] newdata, int length)
        {
            if (_data.Length < _length + length)
                Array.Resize(ref _data, _length + length);

            Array.Copy(newdata, 0, _data, _length, length);
            _length = _length + length;
        }
    }
}
