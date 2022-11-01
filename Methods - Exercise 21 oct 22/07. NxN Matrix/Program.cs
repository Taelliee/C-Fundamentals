using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //a method that receives a single integer n
            //and prints an NxN matrix using this number as a filler

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int x = 0; x < num; x++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
