using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] orderQuantity = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Queue<int> orders = new Queue<int>(orderQuantity);
            int biggestOrder = orders.Max();
            Console.WriteLine(biggestOrder);
            while (orders.Count > 0)
            {
                if (foodQuantity - orders.Peek() >= 0)
                {
                    foodQuantity -= orders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (orders.Count == 0) Console.WriteLine("Orders complete");
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }

        }
    }
}
