using System.Security.Cryptography;

namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLetters = int.Parse(Console.ReadLine());
            int numOfDigits = 0;
            string mainDigit = "";
            int offset = 0;
            int letterIndex = 0;
            string SMS = "";
            for (int i = 0; i < numberOfLetters; i++)
            {
            string letter = Console.ReadLine();
                if (letter == "0")
                {
                    SMS += " ";
                    continue;
                }
                numOfDigits = letter.Length;
                mainDigit = letter[0].ToString();
                offset = (int.Parse(mainDigit) - 2) * 3;
                if (mainDigit == "8" || mainDigit == "9") offset++;
                letterIndex = (offset + numOfDigits - 1);
                SMS +=((char)(97+letterIndex)).ToString();
            }
            Console.WriteLine(SMS);
        }
    }
}