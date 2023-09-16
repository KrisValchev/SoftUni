using System;
using System.Linq;
using System.Collections.Generic;
namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows =int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            string input;
            while ((input =Console.ReadLine())!="END")
            {
                string[] command = input.Split();
                if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= jaggedArray.Length || int.Parse(command[2]) < 0 || int.Parse(command[2]) >= jaggedArray[int.Parse(command[1])].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (command[0] == "Add")
                    {
                        jaggedArray[int.Parse(command[1])][int.Parse(command[2])] += int.Parse(command[3]);
                    }
                    else
                    {
                        jaggedArray[int.Parse(command[1])][int.Parse(command[2])] -= int.Parse(command[3]);
                    }
                }
            }
            foreach (int[] matrix in jaggedArray)
            {
                Console.WriteLine(string.Join(" ",matrix));
            }
        }
    }
}
