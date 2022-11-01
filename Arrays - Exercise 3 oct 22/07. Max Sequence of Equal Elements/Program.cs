using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Finds the longest sequence of equal elements in an array of integers.
            //If several equal sequences are present in the array, prints out the leftmost one.

            int[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int counter = 1;
            int mostRepeated = 0;
            int finalNum = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > mostRepeated)
                {
                    mostRepeated = counter;
                    finalNum = nums[i];
                }
            }

            for (int x = 0; x < mostRepeated; x++)
            {
                Console.Write(finalNum + " ");
            }
        }
    }
}
