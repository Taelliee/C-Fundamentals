using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<int> result = new List<int>();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int[] arrResult = arr[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                foreach (var item in arrResult)
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
