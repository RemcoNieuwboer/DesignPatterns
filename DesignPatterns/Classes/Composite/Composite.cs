using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Classes.Composite
{
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

        public string Display(int depth)
        {
           var s = new StringBuilder();
            s.Append(new string('-', depth) + Name + ": " + _list.Count + " items in list\n");
            foreach (var c in _list)
            {
                s.Append(c.Display(depth + 2));
            }
            return s.ToString();
        }
    }


}