using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
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

            while (input[0] != "end")
            {
                string command = input[0];

                if (command == "Add")
                {
                    collection.Add(int.Parse(input[1]));
                }
                else if (command == "Remove")
                {
                    collection.Remove(int.Parse(input[1]));
                }
                else if (command == "RemoveAt")
                {
                    collection.RemoveAt(int.Parse(input[1]));
                }
                else if (command == "Insert")
                {
                    collection.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }   

                input = Console.ReadLine()
                    .Split()
                    .ToList();
            }

            Console.WriteLine(string.Join(' ', collection));
        }
    }
}
