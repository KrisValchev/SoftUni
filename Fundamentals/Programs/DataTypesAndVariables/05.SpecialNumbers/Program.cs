using System.Diagnostics.CodeAnalysis;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int num = i;
                while (num!=0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                if(sum==7||sum==5||sum==11) Console.WriteLine($"{i} -> True");
                else Console.WriteLine($"{i} -> False");
            }

        }
    }
}