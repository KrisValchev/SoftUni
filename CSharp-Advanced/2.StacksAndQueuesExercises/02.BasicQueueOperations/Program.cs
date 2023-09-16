using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Queue<int> queue = new Queue<int>();
            int numOfElementsToEnqueue = tokens[0];
            int numOfElementsToDequeue = tokens[1];
            int numOfElementsToLookFor = tokens[2];

            for (int i = 0; i < numOfElementsToEnqueue; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < numOfElementsToDequeue; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count != 0)
            {
                if (queue.Contains(numOfElementsToLookFor))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());

                }
            }
            else Console.WriteLine(0);
        }
    }
}
