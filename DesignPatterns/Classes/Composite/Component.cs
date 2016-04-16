using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.Classes.Composite
{
    public class Component<T> : IComponent<T>
    {
        public T Name { get; set; }

        public Component(T name)
        {
            Name = name;
        }

        public void Add(IComponent<T> c)
        {
            throw new Exception("Cannot add to an item");
        }

        public IComponent<T> Remove(T s)
        {
            throw new Exception("Cannot remove directly");
        }

        public string Display(int index)
        {
            return new string('-', index) + Name + "\n";
        }

        public IComponent<T> Find(T s)
        {
            if (s.Equals(Name))
            {
                return this;
            }
            else
            {
                return null;
            }
        }
    }
}