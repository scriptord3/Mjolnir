using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.CA
{
    [Method(methodId: 0x0064, size: MethodAttribute.packet_length_dynamic, name: "CA_LOGIN", direction: MethodAttribute.packetdirection.pd_out)]
    public class Login : IMethodOut
    {
        private static readonly Login defaultInstance = new Login().MakeReadOnly();

        private Login MakeReadOnly()
        {
            return this;
        }

        public static Login DefaultInstance
        {
            get { return defaultInstance; }
        }

        private bool hasVersion;
        private int version_ = -1;
        public bool HasVersion
        {
            get { return hasVersion; }
        }
        public int Version
        {
            get { return version_; }
        }

        private bool hasId;
        private char[] id_ = new char[0x18];
        public bool HasId
        {
            get { return hasId; }
        }
        public char[] Id
        {
            get { return id_; }
        }

        private bool hasPasswd;
        private char[] passwd_ = new char[0x18];
        public bool HasPasswd
        {
            get { return hasPasswd; }
        }
        public char[] Passwd
        {
            get { return passwd_; }
        }

        private bool hasClienttype;
        private Static.ClientType clienttype_ = Static.ClientType.CLIENTTYPE_NONE;
        public bool HasClienttype
        {
            get { return hasClienttype; }
        }
        public Static.ClientType Clienttype
        {
            get { return clienttype_; }
        }

        public void WriteTo(System.IO.BinaryWriter output)
        {
            output.Write(new byte[] { 0x00, 0x64 });

            if (!hasVersion)
                throw new Exception("Version not set!");
            output.Write(version_);

            if (!hasId)
                throw new Exception("Id not set!");
            output.Write(id_);

            if (!hasPasswd)
                throw new Exception("Passwd not set!");
            output.Write(passwd_);

            if (!hasClienttype)
                throw new Exception("Clienttype not set!");
            output.Write(Convert.ToChar(clienttype_));
        }

        public sealed partial class Builder
        {
            public Builder()
            {
                result = DefaultInstance;
                resultIsReadOnly = true;
            }

            private bool resultIsReadOnly;
            private Login result;

            private Login PrepareBuilder()
            {
                if (resultIsReadOnly)
                {
                    Login original = result;
                    result = new Login();
                    resultIsReadOnly = false;
                    MergeFrom(original);
                }
                return result;
            }

            public Builder MergeFrom(Login other)
            {
                if (other == global::Mjolnir.Net.Protocol.Methods.CA.Login.DefaultInstance) return this;
                PrepareBuilder();
                if (other.HasVersion)
                {
                    Version = other.Version;
                }
                return this;
            }

            /*
             * Version
             */
            public bool HasVersion
            {
                get { return result.hasVersion; }
            }
            public int Version
            {
                get { return result.Version; }
                set { SetVersion(value); }
            }
            public Builder SetVersion(int value)
            {
                PrepareBuilder();
                result.hasVersion = true;
                result.version_ = value;
                return this;
            }
            public Builder ClearVersion()
            {
                PrepareBuilder();
                result.hasVersion = false;
                result.version_ = -1;
                return this;
            }

            /*
             * Id
             */
            public bool HasId
            {
                get { return result.hasId; }
            }
            public char[] Id
            {
                get { return result.Id; }
                set { SetId(value); }
            }
            public Builder SetId(char[] value)
            {
                string tmp = new string(value);
                if (tmp.Length > 0x18)
                    tmp = tmp.Substring(0x18);
                tmp = tmp.PadRight(0x18, Convert.ToChar(0x00));

                PrepareBuilder();
                result.hasId = true;
                result.id_ = tmp.ToCharArray();
                return this;
            }
            public Builder ClearId()
            {
                PrepareBuilder();
                result.hasId = false;
                result.id_ = new char[0x18];
                return this;
            }

            /*
             * Passwd
             */
            public bool HasPasswd
            {
                get { return result.hasPasswd; }
            }
            public char[] Passwd
            {
                get { return result.Passwd; }
                set { SetPasswd(value); }
            }
            public Builder SetPasswd(char[] value)
            {
                string tmp = new string(value);
                if (tmp.Length > 0x18)
                    tmp = tmp.Substring(0x18);
                tmp = tmp.PadRight(0x18, Convert.ToChar(0x00));

                PrepareBuilder();
                result.hasPasswd = true;
                result.passwd_ = tmp.ToCharArray();
                return this;
            }
            public Builder ClearPasswd()
            {
                PrepareBuilder();
                result.hasPasswd = false;
                result.passwd_ = new char[0x18];
                return this;
            }

            /*
             * Clienttype
             */
            public bool HasClienttype
            {
                get { return result.hasClienttype; }
            }
            public Static.ClientType Clienttype
            {
                get { return result.Clienttype; }
                set { SetClienttype(value); }
            }
            public Builder SetClienttype(Static.ClientType value)
            {
                PrepareBuilder();
                result.hasClienttype = true;
                result.clienttype_ = value;
                return this;
            }
            public Builder ClearClienttype()
            {
                PrepareBuilder();
                result.hasClienttype = false;
                result.clienttype_ = Static.ClientType.CLIENTTYPE_NONE;
                return this;
            }


            public Login Build()
            {
                return result;
            }
        }

        public static Builder CreateBuilder() { return new Builder(); }
    }
}
