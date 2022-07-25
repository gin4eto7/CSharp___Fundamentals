﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {



            int num = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                var article = new Article(input[0], input[1], input[2]);

                articles.Add(article);
            }
            string com = Console.ReadLine();
            switch (com)
            {
                case "title":
                    articles = articles.OrderBy(x => x.Title).ToList();
                        break;
                case "content":
                    articles = articles.OrderBy(x => x.Content).ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(x => x.Author).ToList();
                    break;
            }

            Console.WriteLine(String.Join(Environment.NewLine, articles));
        }
    }

    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }


        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
