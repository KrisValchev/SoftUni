using System;
using System.Collections.Generic;
namespace _01.ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, string> nameAndAges = new Dictionary<string, string>();
            for (int i = 0; i < lines; i++)
            {
                string text = Console.ReadLine();
                string name = text.Substring(text.IndexOf("@")+1, text.IndexOf("|") - text.IndexOf("@")-1);
                string age = text.Substring(text.IndexOf("#")+1, text.IndexOf("*") - text.IndexOf("#")-1);
                nameAndAges.Add(name, age);
            }
            foreach (var nameAndAge in nameAndAges)
            {
                Console.WriteLine($"{nameAndAge.Key} is {nameAndAge.Value} years old.");
            }
        }
    }
}
