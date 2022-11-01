using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            while (input[0] != "end")
            {
                if (input[0] == "Add")
                {
                    wagons.Add(int.Parse(input[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (maxCapacity - wagons[i] >= int.Parse(input[0]))
                        {
                            wagons[i] += int.Parse(input[0]);
                            break;
                        }
                    }
                }
                input = Console.ReadLine()
                    .Split()
                    .ToList();
            }
            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
