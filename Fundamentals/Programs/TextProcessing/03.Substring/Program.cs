using System;
using System.Text;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string secondLine = Console.ReadLine();
            while (secondLine.IndexOf(word)>=0)
            {
                int startingIndexOfWord = secondLine.IndexOf(word);
               secondLine= secondLine.Remove(startingIndexOfWord, word.Length);
            }
            Console.WriteLine(secondLine);
        }
    }
}
