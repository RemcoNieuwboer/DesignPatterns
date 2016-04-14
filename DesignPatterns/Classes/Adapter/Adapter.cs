using System;

namespace DesignPatterns.Classes.Adapter
{
    public class Adapter : IAdapter
    {
        private readonly IAdaptee _adaptee;
        public Adapter(IAdaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string Request(int a, int b)
        {
            return "Rounded result is: " + (int) Math.Round(_adaptee.SpecificRequest(a, b));
        }
    }
}