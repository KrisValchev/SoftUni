using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> numbersOfOccurrences = new Dictionary<string, int>();
            for (int i = 0; i < strings.Length; i++)
            {
                if (numbersOfOccurrences.ContainsKey(strings[i].ToLower()))
                {
                    numbersOfOccurrences[strings[i]]++;
                }
                else
                {
                    numbersOfOccurrences.Add(strings[i].ToLower(), 1);
                }
            }
            List<string> words = new List<string>();
            foreach (KeyValuePair<string,int> word in numbersOfOccurrences)
            {
                if(word.Value%2!=0)
                {
                    words.Add(word.Key);
                }
            }
            Console.WriteLine(string.Join(" ",words));
        }
    }
}
