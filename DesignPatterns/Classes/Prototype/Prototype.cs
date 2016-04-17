using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatterns.Classes.Prototype
{
    [Serializable]
    public abstract class Prototype<T>
    {
        public T Clone()
        {
            return (T) MemberwiseClone();
        }

        public T Copy()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            T copy = (T) formatter.Deserialize(stream);
            stream.Close();
            return copy;
        }
    }
}
