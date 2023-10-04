using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
		private string name;

		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
        public Person()
        {
			this.Name = "No name";
			this.Age = 1;
        }
        public Person(int age):this()
        {
			this.Age = age;
        }
		public Person(int age, string name):this(age)
		{
			this.Name = name;
		}
        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
