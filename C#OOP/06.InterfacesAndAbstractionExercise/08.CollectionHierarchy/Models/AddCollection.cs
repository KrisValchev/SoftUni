using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using _08.CollectionHierarchy.Interfaces;

namespace _08.CollectionHierarchy.Models
{
    public class AddCollection : IAddable
    {
        private readonly List<string> list;
        public AddCollection()
        {
            list = new List<string>();
        }
        public int Add(string text)
        {
            list.Add(text);
            return list.Count-1;
        }


    }
}
