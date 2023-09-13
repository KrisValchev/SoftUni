using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>(Console.ReadLine().Split());
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                if (command != "Paid")
                {
                    customers.Enqueue(command);
                }
                else
                {
                    while (customers.Count > 0)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
            }
            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
