using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace _05.FilterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ReadPeople();
            string condition =Console.ReadLine();
            int age =int.Parse(Console.ReadLine());
            string format =Console.ReadLine();
            Func<Person, bool> filter = Filter(condition, age);
            Action<Person> printer = CreatePrinter(format);
            PrintFilteredPeople(people, filter, printer);
        }
        static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
        {
            List<Person> filteredPeople=people.Where(x=>filter(x)).ToList();
            foreach (var person in filteredPeople)
            {
                printer(person);
            }
        }
        static Func<Person,bool> Filter(string condition, int ageThreshold)
        {
            if(condition=="older")
            {
                return x => x.Age >= ageThreshold;
            }
            else
            {
                return x => x.Age < ageThreshold;
            }
        }
        static Action<Person> CreatePrinter(string format)
        {
            if(format=="name age")
            {
                return x => Console.WriteLine($"{x.Name} - {x.Age}");
            }
            else if(format=="name")
            {
                return x => Console.WriteLine($"{x.Name}");
            }
            else
            {
                return x => Console.WriteLine($"{x.Age}");
            }
        }
        static List<Person> ReadPeople()
        {
            int number = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine().Split(", ");
                Person person = new Person(command[0], int.Parse(command[1]));
                people.Add(person);
            }
            return people;
        }

    }
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        
    }
}