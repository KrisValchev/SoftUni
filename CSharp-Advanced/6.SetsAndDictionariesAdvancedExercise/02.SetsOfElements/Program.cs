using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lenghts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> uniqueElements = new List<int>();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            for (int i = 0; i < lenghts[0]; i++)
            {
                int number =int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }
            for (int i = 0; i < lenghts[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }
            firstSet.IntersectWith(secondSet);
            Console.WriteLine(string.Join(" ",firstSet));
        }
    }
}
