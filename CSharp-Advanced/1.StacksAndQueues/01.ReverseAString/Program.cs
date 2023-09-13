using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            Stack<char> symbols = new Stack<char>();
            foreach(var letter in message)
            {
                symbols.Push(letter);
            }
            string messageReversed=string.Empty;
            while(symbols.Count>0)
            {
                messageReversed += symbols.Pop();
            }
            Console.WriteLine(messageReversed);
        }
    }
}
