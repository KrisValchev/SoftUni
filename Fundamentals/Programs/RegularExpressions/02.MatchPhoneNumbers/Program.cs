using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace _02.MatchPhoneNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359([ -])2\1\d{3}\1\d{4}\b";
            string phone = Console.ReadLine();
            Regex pattern = new Regex(regex);
            MatchCollection phoneMatches = pattern.Matches(phone);
            string[] matchedPhones = phoneMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ",matchedPhones));
        }
    }
}
