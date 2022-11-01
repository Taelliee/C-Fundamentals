using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            //sums first and last, second and the one before last...

            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            //1 2 3 4 5 --> 6 6 3
            for (int i = 0; i < nums.Count / 2; i++)
            {
                result.Add(nums[i] + nums[nums.Count - 1 - i]);
            }

            if (nums.Count % 2 != 0)
            {
                result.Add(nums[nums.Count / 2]);
            }
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
