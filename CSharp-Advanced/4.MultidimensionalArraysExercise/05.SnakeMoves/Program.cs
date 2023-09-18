using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.SnakeMoves
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
            string snake = Console.ReadLine();
            string path =snake;
            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if(path.Length==0)
                        {
                            path += snake;
                        }
                        matrix[row, col] = path[0];
                        path = path.Remove(0, 1);
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        if (path.Length == 0)
                        {
                            path += snake;
                        }
                        matrix[row, col] = path[0];
                        path = path.Remove(0, 1);
                    }
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
