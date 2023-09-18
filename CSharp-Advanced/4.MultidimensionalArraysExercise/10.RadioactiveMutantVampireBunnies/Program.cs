using System;
using System.Linq;
using System.Collections.Generic;
namespace _10.RadioactiveMutantVampireBunnies
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
            int currentColPosition = 0;
            int currentRowPosition = 0;
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                char[] rowValues = Console.ReadLine().ToCharArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                    if (matrix[row, col] == 'P')
                    {
                        currentColPosition = col;
                        currentRowPosition = row;
                        matrix[currentRowPosition, currentColPosition] = '.';
                    }
                }
            }
            char[] commands = Console.ReadLine().ToCharArray();
            bool youDied = false;
            foreach (var command in commands)
            {
                int oldPlayerRow = currentRowPosition;
                int oldPlayerCol = currentColPosition;

                switch (command)
                {
                    case 'L':
                        currentColPosition--;
                        break;
                    case 'R':
                        currentColPosition++;
                        break;
                    case 'U':
                        currentRowPosition--;
                        break;
                    case 'D':
                        currentRowPosition++;
                        break;
                }
                char[,] newMatrix = new char[rows, cols];
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        newMatrix[row, col] = matrix[row, col];
                    }
                }
                for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            if (matrix[row, col] == 'B')
                            {
                                if (col >= 0 && col < matrix.GetLength(1) - 1)//right
                                {
                                    newMatrix[row, col + 1] = 'B';
                                }
                                if (col > 0 && col < matrix.GetLength(1))//left
                                {
                                    newMatrix[row, col - 1] = 'B';
                                }
                                if (row >= 0 && row < matrix.GetLength(0) - 1)//down
                                {
                                    newMatrix[row + 1, col] = 'B';
                                }
                                if (row > 0 && row < matrix.GetLength(0))//up
                                {
                                    newMatrix[row - 1, col] = 'B';
                                }
                            }
                        }
                    }
                matrix = newMatrix;
                if (currentRowPosition < 0
                    || currentRowPosition >= rows
                    || currentColPosition < 0
                    || currentColPosition >= cols)
                {

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write(matrix[row, col]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"won: {oldPlayerRow} {oldPlayerCol}");
                    break;
                }

                if (matrix[currentRowPosition, currentColPosition] == 'B')
                {
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write(matrix[row, col]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"dead: {currentRowPosition} {currentColPosition}");
                    break;
                }
            }
            //for (int i = 0; i < commands.Length; i++)
            //{

            //    if (commands[i] == 'R')
            //    {
            //        if (currentColPosition < matrix.GetLength(1) - 1)
            //        {
            //            if (matrix[currentRowPosition, currentColPosition - 1] == 'B')
            //            {
            //                youDied = true;
            //            }
            //            matrix[currentRowPosition, currentColPosition] = '.';
            //            matrix[currentRowPosition, ++currentColPosition] = 'P';
            //        }
            //    }
            //    else if (commands[i] == 'L')
            //    {
            //        if (currentColPosition > 0)
            //        {
            //            if (matrix[currentRowPosition, currentColPosition - 1] == 'B')
            //            {
            //                youDied = true;

            //            }
            //            matrix[currentRowPosition, currentColPosition] = '.';
            //            matrix[currentRowPosition, --currentColPosition] = 'P';
            //        }
            //    }
            //    else if (commands[i] == 'U')
            //    {
            //        if (currentRowPosition > 0)
            //        {
            //            if (matrix[currentRowPosition - 1, currentColPosition] == 'B')
            //            {
            //                youDied = true;
            //            }
            //            matrix[currentRowPosition, currentColPosition] = '.';
            //            matrix[--currentRowPosition, currentColPosition] = 'P';
            //        }
            //    }
            //    else
            //    {
            //        if (currentRowPosition < matrix.GetLength(0) - 1)
            //        {
            //            if (matrix[currentRowPosition + 1, currentColPosition] == 'B')
            //            {
            //                youDied = true;
            //            }
            //            matrix[currentRowPosition, currentColPosition] = '.';
            //            matrix[++currentRowPosition, currentColPosition] = 'P';
            //        }
            //    }
            //    char[,] newMatrix = new char[rows, cols];

            //    for (int row = 0; row < rows; row++)
            //    {
            //        for (int col = 0; col < cols; col++)
            //        {
            //            newMatrix[row, col] = matrix[row, col];
            //        }
            //    }
            //    for (int row = 0; row < rows; row++)
            //    {
            //        for (int col = 0; col < cols; col++)
            //        {
            //            if (matrix[row, col] == 'B')
            //            {
            //                if (col >= 0 && col < matrix.GetLength(1) - 1)//right
            //                {
            //                    newMatrix[row, col + 1] = 'B';
            //                }
            //                if (col > 0 && col < matrix.GetLength(1))//left
            //                {
            //                    newMatrix[row, col - 1] = 'B';
            //                }
            //                if (row >= 0 && row < matrix.GetLength(0) - 1)//down
            //                {
            //                    newMatrix[row + 1, col] = 'B';
            //                }
            //                if (row > 0 && row < matrix.GetLength(0))//up
            //                {
            //                    newMatrix[row - 1, col] = 'B';
            //                }
            //            }
            //        }
            //    }
            //    matrix = newMatrix;
            //    if (youDied == true)
            //    {
            //        break;
            //    }
            //    matrix[currentRowPosition, currentColPosition] = 'P';
            //}
            //if (youDied)
            //{
            //    for (int row = 0; row < rows; row++)
            //    {
            //        for (int col = 0; col < cols; col++)
            //        {
            //            Console.Write(matrix[row, col]);
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine($"dead: {currentRowPosition} {currentColPosition}");
            //}
            //else
            //{
            //    matrix[currentRowPosition, currentColPosition] = '.';
            //    for (int row = 0; row < rows; row++)
            //    {
            //        for (int col = 0; col < cols; col++)
            //        {
            //            Console.Write(matrix[row, col]);
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine($"won: {currentRowPosition} {currentColPosition}");
            //}
        }
    }
}
