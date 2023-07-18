using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace _04.SantasSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string pattern = @"[@](?<name>[A-Za-z]+)[^@\-!:>]*[!](?<behavior>[G]|[N])[!]";
            List<string> names = new List<string>();
            while (true)
            {
                string encryptedMessage = Console.ReadLine();
                if (encryptedMessage == "end") break;
                string decryptedMessage = "";
                for (int i = 0; i < encryptedMessage.Length; i++)
                {
                    char symbol = (char)(encryptedMessage[i] - key);
                    decryptedMessage += symbol.ToString();
                }
                Match matchedNameAndBehavior = Regex.Match(decryptedMessage, pattern);
                if(matchedNameAndBehavior.Success)
                {
                    if(matchedNameAndBehavior.Groups["behavior"].Value=="G")
                    {
                        names.Add(matchedNameAndBehavior.Groups["name"].Value);
                    }
                }
            }
            Console.WriteLine(string.Join("\n",names));
        }
    }
}
