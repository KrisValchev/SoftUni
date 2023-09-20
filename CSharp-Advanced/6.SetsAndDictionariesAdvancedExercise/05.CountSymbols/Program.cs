using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> symbolsAndRepeating = new SortedDictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (symbolsAndRepeating.ContainsKey(text[i]))
                {
                    symbolsAndRepeating[text[i]]++;
                }
                else
                {
                    symbolsAndRepeating.Add(text[i], 1);
                }
            }
            foreach (var symbol in symbolsAndRepeating)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
