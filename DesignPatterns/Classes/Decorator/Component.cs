using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.Classes.Decorator
{
    public class Component : IComponent
    {
        public string Operation()
        {
            return "start value ";
        }
    }
}