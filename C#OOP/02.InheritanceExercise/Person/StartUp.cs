using System.Text;
using System;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Child child = new Child(name, age);
            Console.WriteLine(child);
        }
    }
    public class Person
    {
        private int age;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value>0) age = value;
                
            }
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
            this.Name,
           this.Age));
            return stringBuilder.ToString();
        }
    }
    public class Child : Person
    {

        public Child(string name, int age) : base(name, age)
        {

        }
        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if(value<=15)
                {
                    base.Age = value;
                }
            }
        }
    }
}