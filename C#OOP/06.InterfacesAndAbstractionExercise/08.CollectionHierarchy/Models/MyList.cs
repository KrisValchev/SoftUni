using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08.CollectionHierarchy.Interfaces;

namespace _08.CollectionHierarchy.Models
{
    public class MyList : IMyList
    {
        private readonly List<string> list;
        public int Used { get { return list.Count; } }
        public MyList()
        {
            list = new List<string>();
        }
        public int Add(string text)
        {
            list.Insert(0, text);
            return 0;
        }

        public string Remove()
        {
            string firstElement = null;
            if(list.Count>0)
            {
             firstElement = list[0];
            list.RemoveAt(0);
            }
            return firstElement;

        }

    }
}
