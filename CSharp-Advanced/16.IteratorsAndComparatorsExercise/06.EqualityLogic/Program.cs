using EqualityLogic;
using System.Globalization;

namespace _06.EqualityLogic
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<Person> hashSet = new HashSet<Person>();
            SortedSet<Person> sortedSet = new SortedSet<Person>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] personPros = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person()
                {
                    Name = personPros[0],
                    Age = int.Parse(personPros[1]),
                };
                hashSet.Add(person);
                sortedSet.Add(person);
            }
            Console.WriteLine(hashSet.Count);
            Console.WriteLine(sortedSet.Count);
        }
    }
}