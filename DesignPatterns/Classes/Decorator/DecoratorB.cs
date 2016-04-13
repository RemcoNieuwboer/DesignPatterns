using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.Classes.Decorator
{
    public class DecoratorB : IComponent
    {
        private readonly IComponent _component;
        public DecoratorB(IComponent c)
        {
            _component = c;
        }

        public string Operation()
        {
            string s = _component.Operation();
            s += "and other added value ";
            return s;
        }
    }
}