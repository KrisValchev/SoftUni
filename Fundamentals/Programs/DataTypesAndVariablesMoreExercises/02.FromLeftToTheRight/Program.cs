using System.Collections.Immutable;

namespace _02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] separateNumbers = new string[2];  
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                long sum = 0;
                string numbers = Console.ReadLine();
                separateNumbers = numbers.Split(" ");
                if (long.Parse(separateNumbers[0]) >= long.Parse(separateNumbers[1]))
                {
                    separateNumbers[0] = separateNumbers[0].Trim('-');
                    separateNumbers[1] = separateNumbers[1].Trim('-');
                    for (int j = 0; j < separateNumbers[0].Length; j++)
                    {
                        sum +=Math.Abs( separateNumbers[0][j])-48;
                    }
                }
                else
                {
                    separateNumbers[0] = separateNumbers[0].Trim('-');
                    separateNumbers[1] = separateNumbers[1].Trim('-');
                    for (int j = 0; j < separateNumbers[1].Length; j++)
                    {
                        sum += Math.Abs(separateNumbers[1][j])-48;
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}