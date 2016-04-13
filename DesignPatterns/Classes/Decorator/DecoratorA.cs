using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.Classes.Decorator
{
    public class DecoratorA : IComponent
    {
        private readonly IComponent _component;
        public DecoratorA(IComponent c)
        {
            _component = c;
        }

        public string Operation()
        {
            string s = _component.Operation();
            s += "and added value ";
            return s;
        }
    }
}