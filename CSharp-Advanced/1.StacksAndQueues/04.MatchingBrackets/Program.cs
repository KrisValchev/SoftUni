using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> indexOfBracket = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                if(expression[i]=='(')
                {
                    indexOfBracket.Push(i);
                }
                else if(expression[i]==')')
                {
                    string subExpression = expression.Substring(indexOfBracket.Peek(), i - indexOfBracket.Pop()+1);
                    Console.WriteLine(subExpression);
                }
            }

        }
    }
}
