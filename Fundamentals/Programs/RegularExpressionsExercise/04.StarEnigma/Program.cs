using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, string> planetAndAtttackType = new Dictionary<string, string>();
            string pattern = @"@(?<planet>[A-Z][a-z]+)[^@:!\->]*:(?<population>\d+)[^@:!\->]*!(?<type>[A]|[D])![^@:!\->]*->(?<soldiers>\d+)";
           
            for (int i = 0; i < lines; i++)
            {
                string message = Console.ReadLine();
                int countOfLetters = 0;
                for (int j = 0; j < message.Length; j++)
                {
                    if(message[j].ToString().ToLower()=="s" || message[j].ToString().ToLower() == "t"|| message[j].ToString().ToLower() == "a"|| message[j].ToString().ToLower() == "r")
                    {
                        countOfLetters++;
                    }
                }
                string decryptedMessage = "";
                for (int j = 0; j < message.Length; j++)
                {
                    decryptedMessage += ((char)(message[j] - countOfLetters)).ToString();
                }
                Match matchedPlanet = Regex.Match(decryptedMessage, pattern);
                if(matchedPlanet.Success)
                {
                    planetAndAtttackType.Add(matchedPlanet.Groups["planet"].Value, matchedPlanet.Groups["type"].Value);
                }
            }
            Console.WriteLine($"Attacked planets: {planetAndAtttackType.Where(x => x.Value == "A").Count()}");
            foreach (var attackedPlanets in planetAndAtttackType.Where(x=>x.Value=="A").OrderBy(x=>x.Key))
            {
                Console.WriteLine($"-> {attackedPlanets.Key}");
            }
            Console.WriteLine($"Destroyed planets: {planetAndAtttackType.Where(x => x.Value == "D").Count()}");
            foreach (var destroyedPlanets in planetAndAtttackType.Where(x => x.Value == "D").OrderBy(x => x.Key))
            {
                Console.WriteLine($"-> {destroyedPlanets.Key}");
            }
        }
    }
}
