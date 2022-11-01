using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //read an array of integers and condense them by summing all
            //adjacent couples of elements until a single integer remains.

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (arr.Length > 1)
            {
                int[] condensedArr = new int[arr.Length - 1];
                for (int i = 0; i < condensedArr.Length; i++)
                {
                    condensedArr[i] = arr[i] + arr[i + 1];
                }

                arr = condensedArr;
            }

            Console.WriteLine(arr[0]);
        }
    }
}
