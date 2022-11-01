using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shelf = Console.ReadLine()
                .Split('&')
                .ToList();

            List<string> books = Console.ReadLine()
                .Split(" | ")
                .ToList();

            while (books[0] != "Done")
            {
                string command = books[0];
                string bookName = books[1];

                if (command == "Add Book")
                {
                    if (!shelf.Contains(bookName))
                    {
                        shelf.Insert(0, bookName);
                    }
                }
                else if (command == "Take Book")
                {
                    if (shelf.Contains(bookName))
                    {
                        shelf.Remove(bookName);
                    }
                }
                else if (command == "Swap Books")
                {
                    string book1 = books[1];
                    string book2 = books[2];

                    int index1 = shelf.FindIndex(x => x == book1);
                    int index2 = shelf.FindIndex(x => x == book2);

                    if (shelf.Contains(book1) && shelf.Contains(book2))
                    {
                        shelf[index1] = book2;
                        shelf[index2] = book1;
                    }
                }
                else if (command == "Insert Book")
                {
                    if (!shelf.Contains(bookName))
                    {
                        shelf.Add(bookName);
                    }
                }
                else if (command == "Check Book")
                {
                    if (int.Parse(books[1]) < shelf.Count)
                    {
                        Console.WriteLine(shelf.ElementAt(int.Parse(books[1])));
                    }
                }

                books = Console.ReadLine()
                    .Split(" | ")
                    .ToList();
            }

            Console.WriteLine(string.Join(", ", shelf));

        }
    }
}
