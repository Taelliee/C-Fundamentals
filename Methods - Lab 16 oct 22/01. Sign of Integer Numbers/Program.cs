using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //A single integer is given, create a method that
            //checks if the given number is positive, negative, or zero

            int n = int.Parse(Console.ReadLine());
            string type = GetType(n);
            Console.WriteLine($"The number {n} is {type}. ");
        }

        static string GetType(int n)
        {
            string type;
            if (n == 0)
            {
                type = "zero";
            }
            else if (n > 0)
            {
                type = "positive";
            }
            else
            {
                type = "negative";
            }

            return type;
        }
    }
}
