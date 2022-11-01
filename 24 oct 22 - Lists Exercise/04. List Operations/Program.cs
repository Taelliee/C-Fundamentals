using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            while (input[0] != "End")
            {
                string command = input[0];
                if (command == "Add")
                {
                    collection.Add(int.Parse(input[1]));
                }
                else if (command == "Insert")
                {
                    if (int.Parse(input[2]) < collection.Count && int.Parse(input[2]) >= 0)
                    {
                        collection.Insert(int.Parse(input[2]), int.Parse(input[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command == "Remove")
                {
                    if (int.Parse(input[1]) < collection.Count && int.Parse(input[1]) >= 0)
                    {
                        collection.RemoveAt(int.Parse(input[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command == "Shift")
                {
                    if (input[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(input[2]); i++)
                        {
                            collection.Add(collection[0]);
                            collection.RemoveAt(0);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < int.Parse(input[2]); i++)
                        {
                            collection.Insert(0, collection[^1]);
                            collection.RemoveAt(collection.Count - 1);
                        }
                    }
                }
                input = Console.ReadLine()
                    .Split()
                    .ToList();
            }
            Console.WriteLine(string.Join(' ', collection));
        }
    }
}
