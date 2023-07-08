using System;
using System.Text;
namespace _02.AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if(line[i]>char1&& line[i]<char2)
                {
                    sum += line[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
