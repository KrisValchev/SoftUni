using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    public class Citizen : IPerson
    {
        private int age;
        private string name;

        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
    }
}
