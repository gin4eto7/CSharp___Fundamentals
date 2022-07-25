using System;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Artical artical = new Artical(input[0], input[1], input[2]);

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch(command[0])
                {
                    case "Edit":
                        artical.Edit(command[1]);
                        break;
                    case "ChangeAuthor":
                        artical.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        artical.Rename(command[1]);
                        break;
                }
            }
            Console.WriteLine(artical.ToString());
        }
    }

    class Artical
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author  { get; set; }

        public Artical(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public void Edit(string content)
        {
            this.Content = content;
        }

        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }

        public void Rename(string title)
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
