using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program to find all the top integers in an array.
            //A top integer is an integer that is greater than all the elements to its right.

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int x = 0; x < arr.Length; x++)
            {
                int currNum = arr[x];
                bool isTopInteger = true;

                for (int i = x + 1; i < arr.Length; i++)
                {
                    if (currNum <= arr[i])
                    {
                        isTopInteger = false; break;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write(currNum + " ");
                }
            }
        }
    }
}
