using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(", ").ToList();
            string patternDigit = @"\d";
            string patternLetter = @"[A-Za-z]";
            Regex regexDigit = new Regex(patternDigit);
            Regex regexLetter = new Regex(patternLetter);
            Dictionary<string, int> nameAndKm = new Dictionary<string, int>();
            while (true)
            {
                StringBuilder name = new StringBuilder();
                string command = Console.ReadLine();
                if (command == "end of race") break;
                MatchCollection matchedLetters = regexLetter.Matches(command);
                MatchCollection matchedDigit = regexDigit.Matches(command);
                foreach (Match matchLetter in matchedLetters)
                {
                    name.Append(matchLetter.Value);
                }
                if (participants.Contains(name.ToString()))
                {
                    int km = matchedDigit.Sum(x => int.Parse(x.Value));
                    if (nameAndKm.ContainsKey(name.ToString()))
                    {
                        nameAndKm[name.ToString()] += km;
                    }
                    else
                    {
                        nameAndKm.Add(name.ToString(), km);
                    }
                }
            }
            int index = 1;
            foreach (var participant in nameAndKm.OrderByDescending(x => x.Value))
            {
                if (index == 1) Console.WriteLine($"1st place: {participant.Key}");
                else if (index == 2) Console.WriteLine($"2nd place: {participant.Key}");
                else if (index == 3)
                    Console.WriteLine($"3rd place: {participant.Key}");
                index++;
            }
        }
    }
}
