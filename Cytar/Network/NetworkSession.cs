﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.IO;
using Cytar.IO;

namespace Cytar.Network
{
    public abstract class NetworkSession: IDObject
    {
        public abstract bool Connected { get; protected set; }
        public abstract bool SSID { get; protected set; }

        protected abstract Stream InnerStream { get; set; }

        public abstract InputStream InputStream { get; protected set; }

        public abstract OutputStream OutputStream { get; protected set; }

        public abstract int Read(byte[] buffer, int idx, int count);

        public abstract void Write(byte[] buffer, int offset, int count);

        public virtual Session Session { get; internal set; }
        public uint ID { get; internal set; }

        public abstract int ReadByte();

        public abstract void WriteByte(byte value);

        public T ReadObject<T>()
        {
            throw new NotImplementedException();
        }

        public void SendObject<T>(T obj)
        {
            throw new NotImplementedException();
        }

        public abstract void Close();
    }
}
