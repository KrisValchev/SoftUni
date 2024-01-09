using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {
		
        private string fisrtName;

        private string lastName;
        private decimal salary;
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public Person(string firstName,string lastName, int age, decimal salary)
        {
            Salary = salary;
            LastName = lastName;
            Age = age;
            FirstName = firstName;
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
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
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                percentage = percentage / 2;
            }
            this.Salary += percentage * this.Salary/100;
        }
    }
}
