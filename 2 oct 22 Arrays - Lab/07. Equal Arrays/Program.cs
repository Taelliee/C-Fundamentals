﻿using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reads two arrays and determines whether they are identical or not.

            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    sum += arr1[i];
                }
                else
                {
                    Console.WriteLine("Arrays are not identical. " +
                        $"Found difference at {i} index");
                    return;
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
