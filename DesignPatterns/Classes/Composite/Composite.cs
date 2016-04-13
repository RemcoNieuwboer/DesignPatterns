using System;
using System.Collections.Generic;

namespace Patterns.Composite
{
    public interface IComponent<T>
    {
        void Add(IComponent<T> c);
        IComponent<T> Remove(T s);
        string Display(int index);
        IComponent<T> Find(T s);
        T Name { get; set; }
    }

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
            return new string('-', index) + Name;
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

    public class Composite<T> : IComponent<T>
    {
        private readonly List<IComponent<T>> _list;
        private IComponent<T> _holder;
        public IComponent<T> Find(T s)
        {
            _holder = this;
            if (Name.Equals(s)) return this;
            IComponent<T> found = null;
            foreach (IComponent<T> c in _list)
            {
                found = c.Find(s);
                if (found!=null) break;
            }
            return found;
        }

        public T Name { get; set; }

        public Composite(T name)
        {
            Name = name;
            _list = new List<IComponent<T>>();
        }

        public void Add(IComponent<T> c)
        {
            _list.Add(c);
        }

        public IComponent<T> Remove(T s)
        {
            _holder = this;
            IComponent<T> p = _holder.Find(s);
            if (_holder != null)
            {
                ((Composite<T>) _holder)._list.Remove(p);
                return _holder;
            }
            else
            {
                return this;
            }
        }

        public string Display(int index)
        {
            throw new NotImplementedException();
        }
    }


}