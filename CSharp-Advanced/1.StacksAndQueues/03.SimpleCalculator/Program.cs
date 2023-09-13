using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine().Split();
            
           
            Stack<string> reversedExpression = new Stack<string>(expression.Reverse());
                int sum = int.Parse(reversedExpression.Pop());
            while (reversedExpression.Count>0)
            {
                if(reversedExpression.Peek()=="+")
                {
                    reversedExpression.Pop();
                int number= int.Parse(reversedExpression.Pop());
                    sum += number;
                }
               else if (reversedExpression.Peek() == "-")
                {
                    reversedExpression.Pop();
                    int number = int.Parse(reversedExpression.Pop());
                    sum -= number;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
