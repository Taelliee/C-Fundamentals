using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method for printing triangles as shown below:
            //1
            //1 2
            //1 2 3 
            //1 2
            //1

            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                PrintLine(i);
            }

            for (int i = input - 1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }

        private static void PrintLine(int i)
        {
            for (int x = 1; x <= i; x++)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }
}
