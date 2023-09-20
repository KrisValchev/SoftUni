using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            HashSet<string> chemicalElements = new HashSet<string>();
            for (int i = 0; i < number; i++)
            {
                string[] elements = Console.ReadLine().Split();
                for (int j = 0; j < elements.Length; j++)
                {
                    chemicalElements.Add(elements[j]);
                }
            }
            Console.WriteLine(string.Join(" ",chemicalElements.OrderBy(n=>n)));
        }
    }
}
