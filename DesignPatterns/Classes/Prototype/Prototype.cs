using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes.Prototype
{
    [Serializable]
    public abstract class Prototype<T>
    {
        public T Clone()
        {
            return (T) this.MemberwiseClone();
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
