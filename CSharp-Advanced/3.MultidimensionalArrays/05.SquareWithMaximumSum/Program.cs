using System;
using System.Linq;
using System.Collections.Generic;
namespace _05.SquareWithMaximumSum
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
                int[] rowValues = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            int maxSum = 0;
            int indexRowMaxSum = 0;
            int indexColMaxSum = 0;
            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    if (matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1] > maxSum)
                    {
                        maxSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                        indexColMaxSum = col;
                        indexRowMaxSum = row;
                    }
                }
            }
            Console.WriteLine($"{matrix[indexRowMaxSum,indexColMaxSum]} {matrix[indexRowMaxSum, indexColMaxSum+1]}");
            Console.WriteLine($"{matrix[indexRowMaxSum+1,indexColMaxSum]} {matrix[indexRowMaxSum+1, indexColMaxSum+1]}");
            Console.WriteLine(maxSum);
        }
    }
}
