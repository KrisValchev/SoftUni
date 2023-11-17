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
            private set
            {
                if(value<=0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                age = value;
            }
        }


        public Person(string firstName, string lastName, int age, decimal salary)
        {
            Salary = salary;
            LastName = lastName;
            Age = age;
            FirstName = firstName;
        }

        public decimal Salary
        {
            get { return salary; }
            private set
            {
                if (value < 650)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
                salary = value;
            }
        }


        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                lastName = value;
            }
        }

        public string FirstName
        {
            get { return fisrtName; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                fisrtName = value;
            }
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
            this.Salary += percentage * this.Salary / 100;
        }
    }
}
