using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.SquaresOfMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                char[] rowValues = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            int squaresMatrixes = 0;
            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    if(matrix[row,col]==matrix[row,col+1] && matrix[row, col] == matrix[row+1, col] && matrix[row, col] == matrix[row+1, col + 1])
                    {
                        squaresMatrixes++;
                    }
                }
            }
            Console.WriteLine(squaresMatrixes);
        }
    }
}
