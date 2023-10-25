using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIteratorType
{
    public class ListyIterator<T>
    {
        private int index = 0;
        private List<T> list;
        public ListyIterator(List<T> list)
        {
                this.list = list;
        }
        public bool Move()
        {
            if(index<list.Count-1)
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
            if(list.Count==0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(list[index]);
        }
    }
}
