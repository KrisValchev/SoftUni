using System;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] article = Console.ReadLine()
                .Split(", ");
            string title = article[0];
            string content = article[1];
            string author = article[2];
            Article newArticle = new Article(title, content, author);
            int numOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                switch(command[0])
                {
                    case "Edit":
                        newArticle.Edit(command[1]);
                        break;
                    case "ChangeAuthor":
                        newArticle.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        newArticle.Rename(command[1]);
                        break;
                }
            }
            Console.WriteLine(newArticle.ToString());
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
        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
