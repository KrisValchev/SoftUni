using System;
using System.Linq;
using System.Collections.Generic;
namespace _01.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            int[,] matrix = new int[rows, cols];
            int sumOfElements = 0;
            for (int row = 0; row < rows; row++)
            {
               int[] rowValues= Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    sumOfElements += rowValues[col];
                    matrix[row, col] = rowValues[col];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sumOfElements);
        }
    }
}
