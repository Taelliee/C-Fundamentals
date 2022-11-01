using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determines if an element exists in an array for which the sum of
            //all elements to its left is equal to the sum of all elements to its right.
            //If there are no elements to the left or right, their sum is considered to be 0.
            //Prints the index of the element that satisfies the condition or "no" if there is no such element.

            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int x = 0; x < arr.Length; x++)
            {
                int currNum = arr[x];
                int sumBefore = 0;
                int sumAfter = 0;

                for (int i = x + 1; i < arr.Length; i++)
                {
                    sumAfter += arr[i];
                }

                for (int k = 0; k < x; k++)
                {
                    sumBefore += arr[k];
                }

                if (sumBefore == sumAfter)
                {
                    Console.WriteLine(x);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
