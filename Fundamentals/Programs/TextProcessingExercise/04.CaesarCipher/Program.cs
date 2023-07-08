using System;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string newMessage = "";
            for (int i = 0; i < message.Length; i++)
            {
                char newLetter = (char)(message[i]+3);
                newMessage += newLetter;
            }
            Console.WriteLine(newMessage);
        }
    }
}
