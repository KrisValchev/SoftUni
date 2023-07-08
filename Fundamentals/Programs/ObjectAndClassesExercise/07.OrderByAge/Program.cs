using System;
using System.Collections.Generic;
using System.Linq;
namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if(input[0]=="End")
                {
                    break;
                }
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);
                if (people.Exists(x => x.ID == id))
                {
                    people.Find(x => x.ID == id).Name = name;
                    people.Find(x => x.ID == id).Age = age;
                }
                else
                {
                    Person person = new Person(name, id, age);
                    people.Add(person);
                }
            }
            foreach (Person person in people.OrderBy(x=>x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }

    }
    class Person
    {
        public Person(string name,string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
