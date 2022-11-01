using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //sums all of the adjacent equal numbers in a list of decimal numbers,
            //starting from left to right

            List<double> nums = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();

            //3 3 6 1 -> 12 1
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums[i] += nums[i];
                    nums.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
