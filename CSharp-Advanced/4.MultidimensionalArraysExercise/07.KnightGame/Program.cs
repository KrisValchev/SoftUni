using System;
using System.Collections.Generic;
using System.Linq;
namespace _07.KnightGame
{
    class Program
    {
        static int size;
        static void Main(string[] args)
        {
            size = int.Parse(Console.ReadLine());
            if(size<3)
            {
                Console.WriteLine(0);
                return;
            }
            char[,] matrix = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                char[] rowValues = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            int minimumAttackedKnights = 0;
            while (true)
            {

                int mostAttackedKnights = 0;
                int rowMostAttacking = 0;
                int colMostAttacking = 0;
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                    int attackedKnights = 0;
                            if (ValidCell(row - 2, col - 1))
                            {
                                if (matrix[row - 2, col - 1] == 'K')
                                {
                                    attackedKnights++;
                                }
                            }
                            if (ValidCell(row - 2, col + 1))
                            {
                                if (matrix[row - 2, col + 1] == 'K')
                                {
                                    attackedKnights++;
                                }
                            }
                            if (ValidCell(row - 1, col + 2))
                            {
                                if (matrix[row - 1, col + 2] == 'K')
                                {
                                    attackedKnights++;
                                }
                            }
                            if (ValidCell(row + 1, col + 2))
                            {
                                if (matrix[row + 1, col + 2] == 'K')
                                {
                                    attackedKnights++;
                                }
                            }
                            if (ValidCell(row + 2, col + 1))
                            {
                                if (matrix[row + 2, col + 1] == 'K')
                                {
                                    attackedKnights++;
                                }
                            }
                            if (ValidCell(row + 2, col - 1))
                            {
                                if (matrix[row + 2, col - 1] == 'K')
                                {
                                    attackedKnights++;
                                }
                            }
                            if (ValidCell(row + 1, col - 2))
                            {
                                if (matrix[row + 1, col - 2] == 'K')
                                {
                                    attackedKnights++;
                                }
                            }
                            if (ValidCell(row - 1, col - 2))
                            {
                                if (matrix[row - 1, col - 2] == 'K')
                                {
                                    attackedKnights++;
                                }
                            }
                            if (attackedKnights > mostAttackedKnights)
                            {
                                mostAttackedKnights = attackedKnights;
                                rowMostAttacking = row;
                                colMostAttacking = col;
                            }
                        }
                    }
                }
                    if (mostAttackedKnights == 0)
                    {
                        break;
                    }
                    else
                    {
                        matrix[rowMostAttacking, colMostAttacking] = '0';
                        minimumAttackedKnights++;
                    }
            }
            Console.WriteLine(minimumAttackedKnights);
        }
        static bool ValidCell(int row, int col)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }
    }
}
