using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            string message = Console.ReadLine();
            List<char> messageChar = new List<char>();
            for (int i = 0; i < message.Length; i++)
            {
                messageChar.Add(message[i]);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = CalculateTheSumOfDigit(numbers, i);
                messageChar = RemoveChar(messageChar, sum);
            }
        }
        static int CalculateTheSumOfDigit(List<int> list, int index)
        {
           int sum = 0;
            while (list[index] != 0)
            {
                sum += list[index] % 10;
                list[index] /= 10;
            }
            return sum;
        }
        static List<char> RemoveChar(List<char> list, int number)
        {
            int index = 0;
            while(number!=0)
            {
                number--;
                if (index >= list.Count) index = 0;
                index++;
            }
            Console.Write(list[index]);
            list.RemoveAt(index);
            return list;
        }
    }
}
