using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given an integer n. On the next n lines,
            //you will get 2 integers, separated by a space.
            //Form 2 new arrays in a zig-zag pattern.

            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 != 0) //odd lines = 1, 3, 5..
                {
                    firstArray[i-1] = numbers[0];
                    secondArray[i-1] = numbers[1];
                }
                else //even lines = 2, 4, 6...
                {
                    firstArray[i - 1] = numbers[1];
                    secondArray[i - 1] = numbers[0];
                }
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));

        }
    }
}
