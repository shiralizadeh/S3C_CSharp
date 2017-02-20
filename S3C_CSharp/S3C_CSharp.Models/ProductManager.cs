using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3C_CSharp.Models
{
    public class ListManager<T, R>
    {
        protected T[] list = new T[1000];
        protected int index = 0;

        //public int Count { get { return index; } }
        public int Count => index;

        public virtual void Add(T product)
        {
            list[index++] = product;
        }

        public int GetCount()
        {
            return index;
        }
    }
}
