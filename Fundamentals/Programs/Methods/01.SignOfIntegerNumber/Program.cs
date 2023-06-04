using System.Diagnostics;

namespace _01.SignOfIntegerNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            Console.WriteLine($"The number {number} is {SignOfNumber(number)}.");
        }
    static string SignOfNumber(int number)
        {
            if (number < 0) return "negative";
            else if (number > 0) return "positive";
            else return "zero";
        }
    }
}