using System;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string result = "";
            for (int i = 0; i < line.Length-1; i++)
            {
                if(line[i]!=line[i+1])
                {
                    result += line[i];
                }
            }
            result += line[line.Length - 1];
            Console.WriteLine(result);
        }
    }
}
