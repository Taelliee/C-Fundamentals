using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read a list of integers and print them in ascending order, along with their number of occurrences.
            //8.1  2  2  8.1  2

            double[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> numsOccurrence = new SortedDictionary<double, int>();

            foreach (double currNum in nums)
            {
                if (!numsOccurrence.ContainsKey(currNum))
                {
                    numsOccurrence.Add(currNum, 0);
                }
                numsOccurrence[currNum]++;
            }

            foreach (var (k, v) in numsOccurrence)
            {
                Console.WriteLine($"{k} -> {v}");
            }
        }
    }
}
