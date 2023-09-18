using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int row = 0; row < size; row++)
            {
                int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < rowValues.Length; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            int primaryDiagonalSum = 0;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if(col==row)
                    {
                        primaryDiagonalSum += matrix[row, col];
                    }
                }
            }
            int secondaryDiagonalSum = 0;
            for (int row = size; row >=0; row--)
            {
                for (int col = size; col >=0; col--)
                {
                    if(col==size-1-row)
                    {
                        secondaryDiagonalSum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(Math.Abs(primaryDiagonalSum-secondaryDiagonalSum));
        }

    }
}
