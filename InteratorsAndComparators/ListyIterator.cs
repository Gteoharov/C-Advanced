using System;
using System.Collections.Generic;

namespace InteratorsAndComparators
{
    public class ListyIterator<T>
    {
        private List<T> data;
        private int index;

        public ListyIterator(List<T> data)
        {
            this.data = data;
            this.index = 0;
        }

        public bool Move()
        {
            if (HasNext())
            {
                this.index++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            if (index + 1 < this.data.Count)
            {
                return true;
            }
            return false;
        }

        public string Print()
        {
            return this.data[index].ToString();
        }
    }
}
