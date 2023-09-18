using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.MatrixShuffling
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
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] rowValues = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            string input;
            while ((input =Console.ReadLine())!="END")
            {
                string[] command = input.Split();
                if(command.Length==5 && command[0] == "swap")
                {
                    int row1 =int.Parse(command[1]);
                    int col1= int.Parse(command[2]);
                    int row2= int.Parse(command[3]);
                    int col2= int.Parse(command[4]);
                    if((row1 >= 0 && row1 < matrix.GetLength(0) )
                        && (col1 >= 0 && col1 < matrix.GetLength(1))
                        && (row2 >= 0 && row2 < matrix.GetLength(0) )
                        && (col2 >= 0 && col2 < matrix.GetLength(1) ))
                    {
                        string value = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = value;
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
