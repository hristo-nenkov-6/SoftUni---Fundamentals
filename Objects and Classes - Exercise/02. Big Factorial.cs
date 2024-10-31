using System;
using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            List<string> articles = Console.ReadLine().Split(", ").ToList();
            Article article = new Article(articles[0], articles[1], articles[2]);
            int changes = int.Parse(Console.ReadLine());
            for(int i = 0; i < changes; i++)
            {
                List<string> input = Console.ReadLine().Split(": ").ToList();
                switch(input[0])
                {
                    case "Edit":
                        {
                            article.Edit(input[1]);
                            break;
                        }

                    case "ChangeAuthor":
                        {
                            article.ChangeAuthor(input[1]);
                            break;
                        }

                    case "Rename":
                        {
                            article.Rename(input[1]);
                            break;
                        }
                }
            }
            Console.WriteLine(article.ToString());
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
}