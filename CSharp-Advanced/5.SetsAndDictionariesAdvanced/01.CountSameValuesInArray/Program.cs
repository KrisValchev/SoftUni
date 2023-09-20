using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Dictionary < double, int> numAndRepeating = new Dictionary<double, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if(!numAndRepeating.ContainsKey(numbers[i]))
                {
                    numAndRepeating.Add(numbers[i], 1);
                }
                else
                {
                    numAndRepeating[numbers[i]]++;
                }
            }
            foreach (var number in numAndRepeating)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
