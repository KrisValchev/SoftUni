using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] morseCode = {
            ".-", "−...", "-.-.", "-..", ".", "..-..", "..-.", "--.", "....",
            "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-",
            ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            char[] alphabet = {
               'A', 'B', 'C', 'D', 'E', 'E', 'F', 'G', 'H',
            'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q',
            'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };
            string[] text = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            string result = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == "|")
                {
                    result += " ";
                    continue;
                }
                result += alphabet[Array.IndexOf(morseCode, text[i])];
            }
            Console.WriteLine(result) ;
        }
    }
}
