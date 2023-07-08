using System;
using System.Collections.Generic;
namespace _03.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            int numOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCommands; i++)
            {
                string[] article = Console.ReadLine()
                              .Split(", ");
                string title = article[0];
                string content = article[1];
                string author = article[2];
                Article newArticle = new Article(title, content, author);
                articles.Add(newArticle);
            }
            foreach(Article article in articles)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; } 
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

}
