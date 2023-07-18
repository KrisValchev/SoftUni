using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace _01.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {',',' ' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"([@#$^])\1{5,9}";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length !=20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                string firstHalf = "";
                string secondHalf = "";
                for (int j = 0; j < 10; j++)
                {
                    firstHalf += input[i][j];
                }
                for (int j = 10; j < 20; j++)
                {
                    secondHalf += input[i][j];
                }
                Match firstHalfMatch = Regex.Match(firstHalf, pattern);
                Match secondHalfMatch = Regex.Match(secondHalf, pattern);
                if(firstHalfMatch.Success && secondHalfMatch.Success &&(firstHalfMatch.Value.Contains(secondHalfMatch.Value)|| secondHalfMatch.Value.Contains(firstHalfMatch.Value)))
                {
                    char symbol = secondHalfMatch.Value[0];
                    int lenght = Math.Min(secondHalfMatch.Value.Length, firstHalfMatch.Value.Length);
                    if (lenght == 10)
                    {
                        Console.WriteLine($"ticket \"{input[i]}\" - {lenght}{symbol} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{input[i]}\" - {lenght}{symbol}");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{input[i]}\" - no match");
                }
            }
        }
    }
}
