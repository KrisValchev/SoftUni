using System;
using System.Collections.Generic;
using System.Linq;
namespace _08.Bombs
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
            string[] coordinates = Console.ReadLine().Split();
            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] coordinateOfBomb = coordinates[i].Split(",").Select(int.Parse).ToArray();
                int bombRow = coordinateOfBomb[0];
                int bombCol = coordinateOfBomb[1];
                if (matrix[bombRow, bombCol] <= 0) continue;
                int bombPower = matrix[bombRow, bombCol];
                matrix[bombRow, bombCol] = 0;
                if (bombCol >= 0 && bombCol < matrix.GetLength(1) - 1 && matrix[bombRow, bombCol + 1] > 0)//right
                {
                    matrix[bombRow, bombCol + 1] -= bombPower;
                }
                if (bombCol > 0 && bombCol < matrix.GetLength(1) && matrix[bombRow, bombCol - 1] > 0)//left
                {
                    matrix[bombRow, bombCol - 1] -= bombPower;
                }
                if (bombRow >= 0 && bombRow < matrix.GetLength(0) - 1 && matrix[bombRow + 1, bombCol] > 0)//down
                {
                    matrix[bombRow + 1, bombCol] -= bombPower;
                }
                if (bombRow > 0 && bombRow < matrix.GetLength(0) && matrix[bombRow - 1, bombCol] > 0)//up
                {
                    matrix[bombRow - 1, bombCol] -= bombPower;
                }
                if (bombRow > 0 && bombRow < matrix.GetLength(0) && bombCol > 0 && bombCol < matrix.GetLength(1) && matrix[bombRow - 1, bombCol - 1] > 0)//up left
                {
                    matrix[bombRow - 1, bombCol - 1] -= bombPower;
                }
                if (bombRow > 0 && bombRow < matrix.GetLength(0) && bombCol >= 0 && bombCol < matrix.GetLength(1) - 1 && matrix[bombRow - 1, bombCol + 1] > 0)//up right
                {
                    matrix[bombRow - 1, bombCol + 1] -= bombPower;
                }
                if (bombRow >= 0 && bombRow < matrix.GetLength(0) - 1 && bombCol > 0 && bombCol < matrix.GetLength(1) && matrix[bombRow + 1, bombCol - 1] > 0)//down left
                {
                    matrix[bombRow + 1, bombCol - 1] -= bombPower;
                }
                if (bombRow >= 0 && bombRow < matrix.GetLength(0) - 1 && bombCol >= 0 && bombCol < matrix.GetLength(1) - 1 && matrix[bombRow + 1, bombCol + 1] > 0)//down right
                {
                    matrix[bombRow + 1, bombCol + 1] -= bombPower;
                }
            }
            int aliveCells = 0;
            int sumOfAliveCells = 0;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        sumOfAliveCells += matrix[row, col];
                    }
                }
            }
            Console.WriteLine("Alive cells: " + aliveCells);
            Console.WriteLine("Sum: " + sumOfAliveCells);
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
