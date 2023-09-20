using System;
using System.Linq;
using System.Collections.Generic;
namespace _03.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
          int[] orderedNumbers= numbers.OrderBy(numbers => numbers)
                .OrderByDescending(numbers=>numbers)
                .ToArray();
            if(orderedNumbers.Length>3)
            {
                Console.WriteLine($"{orderedNumbers[0]} {orderedNumbers[1]} {orderedNumbers[2]}");
            }
            else
            {
                Console.WriteLine(string.Join(" ",orderedNumbers));
            }
        }
    }
}
