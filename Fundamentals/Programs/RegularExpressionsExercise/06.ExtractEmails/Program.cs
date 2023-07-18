using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace _06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[^\.\-_]\b[a-zA-Z0-9]+([-._a-zA-Z0-9]+)*[@][\w]+(([-]|[.])([\w]+))+";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection matchedEmails = regex.Matches(input);
            foreach (Match email in matchedEmails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
