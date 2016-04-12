using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.Classes.Bridge
{
    public class Abstraction
    {
        private readonly IBridge bridge;
        public Abstraction(IBridge implementation)
        {
            bridge = implementation;
        }

        public string Operation()
        {
            return bridge.Operation();
        }
    }
}