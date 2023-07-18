using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace _03.PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            string patternCapitalLetter = @"([#$%*&])(?<capLetters>[A-Z]+)\1";
            string patternCodeAndLenght = @"(?<code>\d+)[:](?<lenght>\d{2,})";
            string patternWords = @"\b(?<words>[A-Z][^\s]*)";
            Match matchedCapitalLetters = Regex.Match(input[0], patternCapitalLetter);
            MatchCollection matchedCodeAndLenght = Regex.Matches(input[1], patternCodeAndLenght);
            Dictionary<char, int> startingLetterAndLenght = new Dictionary<char, int>();
            startingLetterAndLenght = AddLettersInDictionary(matchedCapitalLetters);
            MatchCollection matchedWords = Regex.Matches(input[2], patternWords);
            List<string> words = new List<string>();
            foreach (KeyValuePair<char,int> word in startingLetterAndLenght)
            {
                int lenght = 0;
                for (int i = 0; i < matchedCodeAndLenght.Count; i++)
                {
                    if (word.Key == int.Parse(matchedCodeAndLenght[i].Groups["code"].Value))
                    {
                        lenght= int.Parse(matchedCodeAndLenght[i].Groups["lenght"].Value) + 1;
                        break;
                    }
                }
                for (int i = 0; i < matchedWords.Count; i++)
                {
                    if(matchedWords[i].Value.StartsWith(word.Key)&& matchedWords[i].Value.Length== lenght)
                    {
                        words.Add(matchedWords[i].Value);
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join("\n",words));
        }
        static Dictionary<char, int> AddLettersInDictionary(Match matchCollection)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i = 0; i < matchCollection.Groups["capLetters"].Length; i++)
            {
                dictionary.Add(matchCollection.Groups["capLetters"].Value[i], 0);
            }
            return dictionary;
        }
    }
}
