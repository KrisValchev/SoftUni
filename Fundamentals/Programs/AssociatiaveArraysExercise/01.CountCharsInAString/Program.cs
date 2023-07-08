using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();
            char[] input = Console.ReadLine().ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if(!count.ContainsKey(input[i]))
                    {
                        count.Add(input[i], 1);
                    }
                    else
                    {
                        count[input[i]]++;
                    }
                }
                else continue;
            }
            foreach (var character in count)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
