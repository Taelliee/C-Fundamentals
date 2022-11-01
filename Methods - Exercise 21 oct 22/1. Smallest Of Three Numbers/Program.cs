using System;

namespace _01._Smallest_Of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //a method that prints out the smallest of three integer numbers
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetTheSmallest(a, b, c));
        }

        static int GetTheSmallest(int a, int b, int c)
        {
            int smallestNum;
            if (a <= b && a <= c)
            {
                smallestNum = a;
            }
            else if (b <= a && b <= c)
            {
                smallestNum = b;
            }
            else
            {
                smallestNum = c;
            }
            return smallestNum;
        }
        
    }
}
