using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Mjolnir.Net.Protocol.Methods
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MethodAttribute : Attribute
    {
        public const     int packet_length_dynamic = -1;

        public uint MethodId { get; private set; }
        public string Name { get; private set; }
        public int Size { get; private set; }

        public MethodAttribute(uint methodId, string name, int size)
        {
            this.MethodId = methodId;
            this.Name = name;
            this.Size = size;
        }
    }

    public static class Method
    {
        public readonly static Dictionary<Type, MethodAttribute> ProvidedMethods = new Dictionary<Type, MethodAttribute>();
        public readonly static Dictionary<Type, IMethod> Methods = new Dictionary<Type, IMethod>();
        public readonly static Dictionary<Type, int> MethodsDataSize = new Dictionary<Type, int>();

        static Method()
        {
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes().Where(type => type.GetInterface("IMethod") != null))
            {
                object[] attributes = type.GetCustomAttributes(typeof(MethodAttribute), true); // get the attributes of the packet.
                if (attributes.Length == 0) return;

                ProvidedMethods.Add(type, (MethodAttribute)attributes[0]);
                Methods.Add(type, (IMethod)Activator.CreateInstance(type));
            }
        }

        public static IMethod GetByID(uint methodId)
        {
            return (from pair in ProvidedMethods let methodInfo = pair.Value where methodInfo.MethodId == methodId select Methods[pair.Key]).FirstOrDefault();
        }

        public static int GetSize(uint methodId)
        {
             return 0;
            //return (from pair in MethodsDataSize let methodInfo = pair.Value where methodInfo.MethodId == methodId select Methods[pair.Key]).FirstOrDefault();
        }
    }
}
