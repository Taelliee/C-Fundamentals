using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            //receives 3 integers
            //a method that returns the sum of the first two integers
            //a method that subtracts the third integer from the result of the sum method

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(SubstractTheThird(a, b, c)); 
        }

        static int SubstractTheThird(int a, int b, int c)
        {
            int sumFirstTwo = GetSumFirstTwo(a, b);
            return sumFirstTwo - c;
        }

        static int GetSumFirstTwo(int a, int b)
        {
            return a + b;
        }
    }
}
