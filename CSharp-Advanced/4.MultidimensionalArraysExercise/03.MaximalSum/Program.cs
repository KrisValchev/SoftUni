using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.MaximalSum
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
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] rowValues = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            int maxSum = 0;
            int indexBestRow = 0;
            int indexBestCol = 0;
            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int rowSquare = 0;
                    int sum = 0;
                    for (int i = row; i <= row + 2; i++)
                    {
                        int colSquare = 0;
                        for (int j = col; j <= col + 2; j++)
                        {
                            sum += matrix[i, j];
                            colSquare++;
                        }
                        rowSquare++;
                    }
                    if(sum>maxSum)
                    {
                        maxSum = sum;
                        indexBestCol = col;
                        indexBestRow = row;
                    }
                }
            }
            Console.WriteLine("Sum = "+ maxSum);
            for (int row = indexBestRow; row <indexBestRow+3; row++)
            {
                for (int col = indexBestCol; col < indexBestCol+3; col++)
                {
                    Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
