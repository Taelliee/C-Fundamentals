using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read an array from the console and sum only its even values.

            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0)
                {
                    sum += n[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
