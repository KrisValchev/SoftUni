using System;
using System.Linq;
using System.Collections.Generic;
namespace _02.OlderFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < numOfPeople; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                family.AddMember(person);
            }
           
            Console.WriteLine(family.GetOldestMember().ToString());
        }
    }
     class Family
    {
        public Family()
        {
            People = new List<Person>();
        }
        public void AddMember(Person member)
        {
            People.Add(member);
        }
       public List<Person> People { get; set; }
       public Person GetOldestMember()
        {
            int maxAge = int.MinValue;
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].Age >= maxAge)
                    maxAge = People[i].Age;
            }
            Person oldestMember = People.Find(x => x.Age == maxAge);
            return oldestMember;
        }
    }
    class Person
    {
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}
