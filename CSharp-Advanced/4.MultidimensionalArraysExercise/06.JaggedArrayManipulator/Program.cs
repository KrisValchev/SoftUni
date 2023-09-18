using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[rows][];
            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split().Select(double.Parse).ToArray();
            }
            for (int row = 0; row < rows - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int i = row; i <= row + 1; i++)
                    {
                        for (int j = 0; j < jaggedArray[row].Length; j++)
                        {
                            jaggedArray[i][j] *= 2;
                        }
                    }
                }
                else
                {
                    for (int i = row; i <= row + 1; i++)
                    {
                        for (int j = 0; j < jaggedArray[i].Length; j++)
                        {
                            jaggedArray[i][j] /= 2;
                        }
                    }
                }
            }
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                if (command[0] == "Add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);
                    if (row >= 0 && row < jaggedArray.Length)
                    {
                        if (col >= 0 && col < jaggedArray[row].Length)
                        {
                            jaggedArray[row][col] += value;
                        }
                    }

                }
                if (command[0] == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);
                    if (row >= 0 && row < jaggedArray.Length)
                    {
                        if (col >= 0 && col < jaggedArray[row].Length)
                        {
                            jaggedArray[row][col] -= value;
                        }
                    }
                }
            }
            foreach (double[] matrix in jaggedArray)
            {
                Console.WriteLine(string.Join(" ",matrix));
            }
        }
    }
}
