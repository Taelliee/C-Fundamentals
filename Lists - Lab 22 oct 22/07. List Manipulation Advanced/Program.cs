using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            bool isChanged = false;

            while (input[0] != "end")
            {
                string command = input[0];

                if (command == "Add")
                {
                    collection.Add(int.Parse(input[1]));
                    isChanged = true;
                }
                else if (command == "Remove")
                {
                    collection.Remove(int.Parse(input[1]));
                    isChanged = true;
                }
                else if (command == "RemoveAt")
                {
                    collection.RemoveAt(int.Parse(input[1]));
                    isChanged = true;
                }
                else if (command == "Insert")
                {
                    collection.Insert(int.Parse(input[2]), int.Parse(input[1]));
                    isChanged = true;
                }
                else if (command == "Contains")
                {
                    if (collection.Contains(int.Parse(input[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    Console.WriteLine(string.Join(' ', collection.Where(x => x % 2 == 0)));
                }
                else if (command == "PrintOdd")
                {
                    Console.WriteLine(string.Join(' ', collection.Where(x => x % 2 != 0)));
                }
                else if (command == "GetSum")
                {
                    Console.WriteLine(collection.Sum());
                }
                else if (command == "Filter")
                {
                    string condition = input[1];
                    int number = int.Parse(input[2]);
                    
                    switch (condition)
                    {
                        case "<":
                            Console.WriteLine(string.Join(' ', collection.Where(x => x < number)));
                            break;
                        case ">":
                            Console.WriteLine(string.Join(' ', collection.Where(x => x > number)));
                            break;
                        case ">=":
                            Console.WriteLine(string.Join(' ', collection.Where(x => x >= number)));
                            break;
                        case "<=":
                            Console.WriteLine(string.Join(' ', collection.Where(x => x <= number)));
                            break;
                    }
                }

                input = Console.ReadLine()
                    .Split()
                    .ToList();
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(' ', collection));
            }
        }
    }
}
