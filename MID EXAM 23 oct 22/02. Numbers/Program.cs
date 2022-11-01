using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Numbers
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
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (input[0] != "Finish")
            {
                string command = input[0];
                int value = int.Parse(input[1]);

                if (command == "Add")
                {
                    collection.Add(value);
                }
                else if (command == "Remove")
                {
                    collection.Remove(value);
                }
                else if (command == "Replace")
                {
                    if (collection.Contains(value))
                    {
                        for (int i = 0; i < collection.Count; i++)
                        {
                            if (collection[i] == int.Parse(input[1]))
                            {
                                collection[i] = int.Parse(input[2]);
                                break;
                            }
                        }
                    }
                }
                else if (command == "Collapse")
                {
                    collection.RemoveAll(x => x < value);
                }

                input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            Console.WriteLine(string.Join(' ', collection));

        }
    }
}
