using System;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string title = input[0];
            string content = input[1];
            string author = input[2];
            
            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string commandMethod = command[0];
                string text = command[1];

                if (commandMethod == "Edit")
                {
                    article.Edit(ref content, text);
                }
                else if (commandMethod == "ChangeAuthor")
                {
                    article.ChangeAuthor(ref author, text);
                }
                else if (commandMethod == "Rename")
                {
                    article.Rename(ref title, text);
                }
            }
            Console.WriteLine($"{title} - {content}: {author}");
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public string Edit(ref string content, string text)
        {
            content = text;
            return content;
        }
        public string ChangeAuthor(ref string author, string text)
        {
            author = text;
            return author;
        }
        public string Rename(ref string title, string text)
        {
            title = text;
            return title;
        }
    }
}
