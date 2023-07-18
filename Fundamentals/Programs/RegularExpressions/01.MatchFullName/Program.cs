using System;
using System.Text.RegularExpressions;
namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z]{1}[a-z]{1,} [A-Z]{1}[a-z]{1,}\b";
            MatchCollection matchedNames = Regex.Matches(input,pattern);
            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value+" ");
            }
            Console.WriteLine();
        }
    }
}
