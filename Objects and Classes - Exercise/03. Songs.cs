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
            int changes = int.Parse(Console.ReadLine());
            List<Article> articleList = new List<Article>();
            for(int i = 0; i < changes; i++)
            {
                List<string> list = Console.ReadLine().Split(", ").ToList();
                string title = list[0];
                string concept = list[1];
                string author = list[2];
                Article article = new Article(title, concept, author);

                articleList.Add(article);
            }
            foreach(Article art in articleList)
            {
                Console.WriteLine(art);
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
}