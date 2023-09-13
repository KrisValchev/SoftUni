using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.StackAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(x=>int.Parse(x)).ToArray();
            Stack<int> numbers = new Stack<int>(integers);
            string input;
            while ((input=Console.ReadLine()).ToLower()!="end")
            {
                string[] command = input.Split();
                if(command[0].ToLower()=="add")
                {
                    int num1 = int.Parse(command[1]);
                    int num2 = int.Parse(command[2]);
                    numbers.Push(num1);
                    numbers.Push(num2);
                }
                else if(command[0].ToLower() == "remove")
                {
                    if (numbers.Count >= int.Parse(command[1]))
                    {
                        for (int i = 0; i < int.Parse(command[1]); i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
