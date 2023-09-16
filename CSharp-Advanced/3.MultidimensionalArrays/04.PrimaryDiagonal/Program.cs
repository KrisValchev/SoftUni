using System;
using System.Linq;
using System.Collections.Generic;
namespace _04.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size =int.Parse(Console.ReadLine());
            int[,] matrix = new int[size,size];
            for (int row = 0; row < size; row++)
            {
                int[] rowValue = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowValue[col];
                }
            }
            int sumOfDiagonal =0;
            for (int col = 0; col < size; col++)
            {

                for (int row = 0; row < size; row++)
                {
                    if (row == col)
                    {
                        sumOfDiagonal += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(sumOfDiagonal);
        }
    }
}
