using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.Classes.Flyweight
{
    public class Flyweight : IFlyweight
    {
        private string _intrinsicstatevalue;

        public string IntrinsicState
        {
            get
            {
                return _intrinsicstatevalue;
            }           
        }

        public void Operation(string value)
        {
            _intrinsicstatevalue = value;
        }
    }
}