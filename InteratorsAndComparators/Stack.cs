using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace InteratorsAndComparators
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> data;

        public Stack(params T[] data)
        {
            this.data = data.ToList();
        }

        public void Push(params T[] itemsToAdd)
        {
            this.data.AddRange(itemsToAdd);
        }

        public T Pop()
        {
            if (this.data.Count == 0)
            {
                throw new ArgumentException("No elements");
            }
            return this.data[this.data.Count - 1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.data.Count - 1; i >= 0; i--)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
          => GetEnumerator();
    }
}
