using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _03.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            List<char> nonNumbers = new List<char>();
            List<int> numbers = new List<int>();
            nonNumbers = TakeNonNumbers(encryptedMessage);
            numbers = TakeNumbers(encryptedMessage);
            List<int> evenNumbers = new List<int>();
            evenNumbers = TakeList(numbers);
            List<int> oddNumbers = new List<int>();
            oddNumbers = SkipList(numbers);
            StringBuilder result = new StringBuilder();


            for (int i = 0; i < evenNumbers.Count; i++)
            {
                for (int j = 0; j < evenNumbers[i]; j++)
                    if (nonNumbers.Count > 0)
                    {
                        result.Append(nonNumbers[0]);
                        nonNumbers.RemoveAt(0);
                    }

                if (i >= oddNumbers.Count) break;

                for (int j = 0; j < oddNumbers[i]; j++)
                {
                    if (nonNumbers.Count > 0) nonNumbers.RemoveAt(0);
                }
            }
            Console.WriteLine(result.ToString());
        }
        static List<char> TakeNonNumbers(string message)
        {
            List<char> nonNumbers = new List<char>();
            for (int i = 0; i < message.Length; i++)
            {
                if (!int.TryParse(message[i].ToString(), out int number))
                {
                    nonNumbers.Add(message[i]);
                }
            }
            return nonNumbers;
        }
        static List<int> TakeNumbers(string message)
        {
            List<int> nonNumbers = new List<int>();
            for (int i = 0; i < message.Length; i++)
            {
                if (int.TryParse(message[i].ToString(), out int number))
                {
                    nonNumbers.Add(int.Parse(message[i].ToString()));
                }
            }
            return nonNumbers;
        }
        static List<int> TakeList(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i%2==0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }
            return evenNumbers;
        }
        static List<int> SkipList(List<int> numbers)
        {
            List<int> oddNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumbers.Add(numbers[i]);
                }
            }
            return oddNumbers;
        }
        
    }
}
