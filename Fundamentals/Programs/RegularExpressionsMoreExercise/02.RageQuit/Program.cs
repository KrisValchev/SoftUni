using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace _02.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<symbols>[^\d]+)(?<repeating>[\d]+)";
            Regex regex = new Regex(pattern);
            MatchCollection matchedSymbols = regex.Matches(input);
            StringBuilder rageMessage = new StringBuilder();
            StringBuilder repeatingSymbols = new StringBuilder();
            foreach (Match match in matchedSymbols)
            {
                string symbol = match.Groups["symbols"].Value.ToString().ToUpper();
                for (int i = 0; i < int.Parse(match.Groups["repeating"].Value); i++)
                {
                    repeatingSymbols.Append(symbol);
                }
            }
                rageMessage.Append(repeatingSymbols);

            Console.WriteLine($"Unique symbols used: {rageMessage.ToString().Distinct().Count()}");
            Console.WriteLine($"{rageMessage}");
        }
    }
}
