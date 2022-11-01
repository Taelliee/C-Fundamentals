using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints all unique pairs in an array of integers
            //whose sum is equal to a given number

            int[] arr = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                for (int x = i + 1; x < arr.Length; x++)
                {
                    if (arr[i] + arr[x] == num)
                    {
                        Console.WriteLine(arr[i] + " " + arr[x]); break;
                    }
                }
            }

        }
    }
}
