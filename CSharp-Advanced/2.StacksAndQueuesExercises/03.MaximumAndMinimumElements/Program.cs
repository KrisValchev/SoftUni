using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.MaximumAndMinimumElements
{
    class Program
    {
        static void Main(string[] args)
        {
            short queries = short.Parse(Console.ReadLine());
            Stack<short> stack = new Stack<short>();
            for (int i = 0; i < queries; i++)
            {
                short[] type = Console.ReadLine().Split().Select(short.Parse).ToArray();
                if (type[0] == 1) stack.Push(type[1]);
                if (stack.Count != 0) 
                {
                    if (type[0] == 2) stack.Pop();
                    else if (type[0] == 3)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    else if(type[0]==4)
                    {
                        if (stack.Count == 0) break;
                        Console.WriteLine(stack.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
