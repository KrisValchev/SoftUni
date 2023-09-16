using System;
using System.Linq;
using System.Collections.Generic;
namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size =int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[size][];
            pascalTriangle[0] = new long[1] { 1 };
            for (int row = 1; row < size; row++)
            {
                pascalTriangle[row] = new long[row + 1];
                for (int index = 0; index < pascalTriangle[row].Length; index++)
                {
                    if(index<pascalTriangle[row-1].Length)
                    {
                        pascalTriangle[row][index] += pascalTriangle[row - 1][index];
                    }
                    if(index>0)
                    {
                        pascalTriangle[row][index] += pascalTriangle[row - 1][index - 1];
                    }
                }
            }
            foreach (long[] matrix in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ",matrix));
            }
        }
    }
}
