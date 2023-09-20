using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNmaes =int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < numberOfNmaes; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }
            Console.WriteLine(string.Join("\n",names));
        }
    }
}
