using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Queue<int> numbers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            List<int> evenNumbers = new List<int>();
            while (numbers.Count>0)
            {
                if(numbers.Peek()%2==0)
                {
                    evenNumbers.Add(numbers.Dequeue());
                }
                else
                {
                    numbers.Dequeue();
                }

            }
            Console.WriteLine(string.Join(", ",evenNumbers));

        }
    }
}
