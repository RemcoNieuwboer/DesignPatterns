using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes.Flyweight
{
    public interface IFlyweight
    {
        string IntrinsicState { get; set; }
        void Operation(string value); //ExtrinsicState     
    }
}
