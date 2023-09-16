using System;
using System.Linq;
using System.Collections.Generic;
namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Stack<int> stack = new Stack<int>();
            int numOfElementsToPush = tokens[0];
            int numOfElementsToPop = tokens[1];
            int numOfElementsToLookFor = tokens[2];

            for (int i = 0; i < numOfElementsToPush; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < numOfElementsToPop; i++)
            {
                stack.Pop();
            }
            if (stack.Count != 0)
            {
                if (stack.Contains(numOfElementsToLookFor))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());

                }
            }
            else Console.WriteLine(0);


        }
    }
}
