using System.Collections.Generic;

namespace DesignPatterns.Classes.Flyweight
{
    public class FLyweightFactory
    {
        private readonly Dictionary<string, IFlyweight> _flyweights = new Dictionary<string, IFlyweight>();

        public FLyweightFactory()
        {
            _flyweights.Clear();
        }

        public int Count()
        {
            return _flyweights.Count;
        }

        public IFlyweight this[string index] {
            get {
                if (!_flyweights.ContainsKey(index))
                {
                    _flyweights[index] = new Flyweight();                   
                }
                return _flyweights[index];
            }
        }
    }
}