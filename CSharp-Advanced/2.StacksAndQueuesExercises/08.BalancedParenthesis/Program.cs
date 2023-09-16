using System;
using System.Collections.Generic;
using System.Linq;
namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
         
            for (int i = 0; i < expression.Length; i++)
            {
                var currentValue = stack.TryPeek(out var result);
                if(result=='['&& expression[i]==']') //TryPeek(out var res)
                {
                    stack.Pop();
                }
               else if (result== '(' && expression[i] == ')')
                {
                    stack.Pop();
                }
               else if (result == '{' && expression[i] == '}')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(expression[i]);
                }
            }
            if (stack.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
