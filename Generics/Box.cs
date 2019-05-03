using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    public class Box<T>
    {
        private List<T> value;

        public Box()
        {
            this.value = new List<T>();
        }

        public int Count
        {
            get
            {
                return this.value.Count;
            }
        }

        public void Add(T element)
        {
            this.value.Add(element);
        }

        public T Remove()
        {
            var last = this.value.Last();
            this.value.RemoveAt(value.Count - 1);
            return last;
        }
    }
}
