using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> numbersOfOccurrences = new SortedDictionary<double, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbersOfOccurrences.ContainsKey(numbers[i]))
                {
                    numbersOfOccurrences[numbers[i]]++;
                }
                else
                {
                    numbersOfOccurrences.Add(numbers[i], 1);
                }
            }
            foreach (KeyValuePair<double,int> number in numbersOfOccurrences)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
