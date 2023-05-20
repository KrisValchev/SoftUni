using System;
using System.Runtime.InteropServices;

namespace _06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            bool isBalanced = false;
            bool areReversed = false;
            bool isOpen = false;
            bool isClosed = false;
            int counOfOpenBrackets = 0;
            int counOfClosedBrackets = 0;
            for (int i = 0; i < lines; i++)
            {
                string text = Console.ReadLine();
                
                if (text == "(")
                {
                    counOfOpenBrackets++;
                }
                if (text == ")")
                {
                    counOfClosedBrackets++;
                }
            
                if (counOfClosedBrackets > counOfOpenBrackets)areReversed=true;
            }
            if (counOfClosedBrackets == counOfOpenBrackets) isBalanced = true;
            if (isBalanced == true && areReversed==false) Console.WriteLine("BALANCED");
            else Console.WriteLine("UNBALANCED");
        }
    }
}