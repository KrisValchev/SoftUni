﻿namespace _09.CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char character1 = char.Parse(Console.ReadLine());
            char character2 = char.Parse(Console.ReadLine());
            char character3 = char.Parse(Console.ReadLine());
            Console.WriteLine($"{character1}{character2}{character3}");
        }
    }
}