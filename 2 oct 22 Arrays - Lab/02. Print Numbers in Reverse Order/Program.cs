using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read n numbers and print them in reverse order,
            //separated by a single space.

            int[] n = new int[int.Parse(Console.ReadLine())];

            for (int i = n.Length - 1; i >= 0; i--)
            {
                int input = int.Parse(Console.ReadLine());
                n[i] = input;
            }
            Console.WriteLine(string.Join(" ", n));

        }
    }
}
