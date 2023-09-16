using System;
using System.Linq;
using System.Collections.Generic;
namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] rowValue = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValue[col];
                }
            }
            int[] sumOfColumn = new int[cols];
            for (int col = 0; col < cols; col++)
            {
                
                for (int row = 0; row < rows; row++)
                {
                    sumOfColumn[col] += matrix[row, col];
                }
                Console.WriteLine(sumOfColumn[col]);
            }
           
        }
    }
}
