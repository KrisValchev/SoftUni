using System;
using System.Text;
namespace _05.DigitsLettersAndOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string digits = "";
            string letters = "";
            string otherChars = "";
            for (int i = 0; i < text.Length; i++)
            {
                if(char.IsDigit(text[i]))
                {
                    digits += text[i];
                }
                else  if(char.IsLetter(text[i]))
                {
                    letters += text[i];
                }
                else 
                {
                    otherChars += text[i];
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherChars);
        }
    }
}
