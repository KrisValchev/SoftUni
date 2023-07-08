using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            Random rnd = new Random();
            int randomIndex = 0;
            string previousWord = "";
            for (int i = 0; i < words.Count; i++)
            {
                previousWord = words[i];
                randomIndex = rnd.Next(0, words.Count);
                words[i] = words[randomIndex];
                words[randomIndex] = previousWord;

            }
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}

