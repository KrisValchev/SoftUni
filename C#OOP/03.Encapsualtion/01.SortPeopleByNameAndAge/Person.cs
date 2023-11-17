using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {
        private string fisrtName;

        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            Age = age;
            LastName = lastName;
            FirstName = firstName;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return fisrtName; }
            set { fisrtName = value; }
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}
