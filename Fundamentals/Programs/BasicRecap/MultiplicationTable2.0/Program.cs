﻿namespace MultiplicationTable2._0
{
        internal class Program
        {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            if (times > 10) Console.WriteLine($"{number} X {times} = {number * times}");
            else
            {
                for (int i = times; i <= 10; i++)
                {
                    int multiply = number * i;
                    Console.WriteLine($"{number} X {i} = {multiply}");
                }
            }
        }
        }
}