using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class Box<T>
    {
        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public List<T> Data 
        {
            get 
            {
                return this.data;
            }
        }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public T Remove()
        {
            var last = this.data.Last();
            this.data.RemoveAt(data.Count - 1);
            return last;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in this.data)
            {
                stringBuilder.AppendLine($"{typeof(T)}: {item}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
