using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string result = "";
            int index = 0;
            int indexOfCharactersToSkip = 0;
            int numberToSkip = 0;
            while (index < line.Length)
            {
                result += line[index];

                if (line[index] == '>' && char.IsDigit(line[index + 1]))
                {
                    indexOfCharactersToSkip = int.Parse(line[++index].ToString()) + numberToSkip;
                    numberToSkip = indexOfCharactersToSkip;
                    for (int i = 1; i <= indexOfCharactersToSkip; i++)
                    {
                        index++;
                        numberToSkip--;
                        if (index >= line.Length) break;
                        if (line[index] == '>') break;
                    }
                }
                else
                {
                    index++;
                }

            }
            Console.WriteLine(result);
        }
    }
}
