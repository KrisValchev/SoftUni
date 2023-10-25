using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Collection
{
    public class ListyIterator<T>:IEnumerable<T>
    {
        private int index = 0;
        private List<T> list;
        public ListyIterator(List<T> list)
        {
            this.list = list;
        }
        public bool Move()
        {
            if (index < list.Count - 1)
            {
                index++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            return index < list.Count - 1;
        }
        public void Print()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(list[index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0;i<list.Count;i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
    }
}
