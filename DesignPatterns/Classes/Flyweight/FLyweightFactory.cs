using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.Classes.Flyweight
{
    public class FLyweightFactory
    {
        Dictionary<string, IFlyweight> flyweights = new Dictionary<string, IFlyweight>();

        public FLyweightFactory()
        {
            flyweights.Clear();
        }

        public int Count()
        {
            return flyweights.Count;
        }

        public IFlyweight this[string index] {
            get {
                if (!flyweights.ContainsKey(index))
                {
                    flyweights[index] = new Flyweight();                   
                }
                return flyweights[index];
            }
        }
    }
}