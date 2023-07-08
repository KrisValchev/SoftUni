using System;
using System.Collections.Generic;
namespace _05.HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string titleOfArticle = Console.ReadLine();
            string contentOfArticle = Console.ReadLine();
            List<string> comments = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of comments") break;
                comments.Add(input);
            }
            Console.Write($"<h1>\n    {titleOfArticle}\n</h1>");
            Console.Write($"\n<article>\n    {contentOfArticle}\n</article>");
            foreach (var comment in comments)
            {
                Console.Write($"\n<div>\n    {comment}\n</div>");
            }
        }
    }
}
