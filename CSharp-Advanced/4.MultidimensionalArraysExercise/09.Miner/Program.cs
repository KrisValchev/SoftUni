using System;
using System.Collections.Generic;
using System.Linq;
namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int mineSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[mineSize, mineSize];
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int currentRowPosition = 0;
            int currentColPosition = 0;
            int amountOfCoal = 0;
            for (int row = 0; row < mineSize; row++)
            {
                char [] rowValues = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < rowValues.Length; col++)
                {
                    matrix[row, col] = rowValues[col];
                    if(matrix[row,col]=='s')
                    {
                        currentColPosition = col;
                        currentRowPosition = row;
                    }
                    if (matrix[row, col] == 'c')
                    {
                        amountOfCoal++;
                    }
                }
            }
            int collectedCoal = 0;
            for (int i = 0; i < commands.Length; i++)
            {
                
                if(commands[i]=="right")
                {
                    if(currentColPosition<matrix.GetLength(1)-1)
                    {
                        if(matrix[currentRowPosition,currentColPosition+1]=='c')
                        {
                            collectedCoal++;
                        }
                        else if(matrix[currentRowPosition, currentColPosition + 1] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currentRowPosition}, {currentColPosition+1})");
                            return;
                        }
                        matrix[currentRowPosition, currentColPosition] = '*';
                        matrix[currentRowPosition, ++currentColPosition] = 's';
                    }
                }
                else if (commands[i] == "left")
                {
                    if (currentColPosition >0)
                    {
                        if (matrix[currentRowPosition, currentColPosition - 1] == 'c')
                        {
                            collectedCoal++;
                        }
                        else if (matrix[currentRowPosition, currentColPosition - 1] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currentRowPosition}, {currentColPosition - 1})");
                            return;
                        }
                        matrix[currentRowPosition, currentColPosition] = '*';
                        matrix[currentRowPosition, --currentColPosition] = 's';
                    }
                }
                else if (commands[i] == "up")
                {
                    if (currentRowPosition > 0)
                    {
                        if (matrix[currentRowPosition-1 , currentColPosition ] == 'c')
                        {
                            collectedCoal++;
                        }
                        else if (matrix[currentRowPosition - 1, currentColPosition] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currentRowPosition-1}, {currentColPosition})");
                            return;
                        }
                        matrix[currentRowPosition, currentColPosition] = '*';
                        matrix[--currentRowPosition, currentColPosition] = 's';
                    }
                }
                else
                {
                    if (currentRowPosition <matrix.GetLength(0)-1)
                    {
                        if (matrix[currentRowPosition + 1, currentColPosition] == 'c')
                        {
                            collectedCoal++;
                        }
                        else if (matrix[currentRowPosition + 1, currentColPosition] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currentRowPosition + 1}, {currentColPosition})");
                            return;
                        }
                        matrix[currentRowPosition, currentColPosition] = '*';
                        matrix[++currentRowPosition, currentColPosition] = 's';
                    }
                }
                if (amountOfCoal == collectedCoal)
                {
                    Console.WriteLine($"You collected all coals! ({ currentRowPosition}, { currentColPosition})");
                    return;
                }
            }
            Console.WriteLine($"{ amountOfCoal-collectedCoal} coals left. ({ currentRowPosition}, { currentColPosition})");
        }
    }
}
