using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.Classes.Flyweight
{
    public class Flyweight : IFlyweight
    {
        private string IntrinsicStateValue;

        public string IntrinsicState
        {
            get
            {
                return IntrinsicStateValue;
            }

            set
            {
                IntrinsicStateValue = value;
            }
        }

        public void Operation(string value)
        {
            IntrinsicStateValue = value;
        }
    }
}