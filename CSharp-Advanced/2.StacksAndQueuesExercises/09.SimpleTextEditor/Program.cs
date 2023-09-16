using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            Stack<string> commands = new Stack<string>();
            Stack<string> commandType = new Stack<string>();
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] command = Console.ReadLine().Split();
                if(command[0]=="1")
                {
                    commands.Push(command[1]);
                    commandType.Push(command[0]);
                    text.Append(command[1]);
                }
                else if(command[0]=="2")
                {
                    commands.Push(text.ToString().Substring(text.Length - int.Parse(command[1]), int.Parse(command[1])));
                    commandType.Push(command[1]);
                    text.Remove(text.Length - int.Parse(command[1]), int.Parse(command[1]));
                }
                else if(command[0] == "3")
                {
                    Console.WriteLine(text[int.Parse(command[1])-1]);
                }
                else
                {
                    if(commandType.Pop()=="1")
                    {
                        text.Replace(commands.Pop(),"");
                    }
                    else
                    {
                        text.Append(commands.Pop());
                    }
                }
            }
        }
    }
}
