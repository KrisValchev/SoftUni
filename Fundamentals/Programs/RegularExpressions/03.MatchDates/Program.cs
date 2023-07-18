using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(-|\.|\/)(?<month>[A-Z]{1}[a-z]{2})\1(?<year>\d{4})\b";
            string dates = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matchedDates = regex.Matches(dates);
            foreach (Match date in matchedDates)
            {
                Console.WriteLine($"Day: {date.Groups["day"].Value}, Month: {date.Groups["month"].Value}, Year: {date.Groups["year"].Value}");
            }
        }
    }
}
