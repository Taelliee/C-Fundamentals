using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
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
                if (input[0] == "Delete")
                {
                    collection.RemoveAll(x => x == int.Parse(input[1]));
                }
                else if (input[0] == "Insert")
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
