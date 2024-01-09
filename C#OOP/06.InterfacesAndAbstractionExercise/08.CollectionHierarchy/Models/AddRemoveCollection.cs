using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using _08.CollectionHierarchy.Interfaces;

namespace _08.CollectionHierarchy.Models
{
    public class AddRemoveCollection : IRemovable
    {
        private readonly List<string> list;
        public AddRemoveCollection()
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
            string lastElement = null;
            if (list.Count > 0)
            {
                 lastElement = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
            }
            return lastElement;
        }
    }
}
