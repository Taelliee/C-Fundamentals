using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //The method should return a new string,
            //containing the initial one, repeated n times without space.

            string input = Console.ReadLine();
            int iterations = int.Parse(Console.ReadLine());
            
            Console.WriteLine(RepeatInput(input, iterations));
        }

        static string RepeatInput(string input, int iterations)
        {
            string result = "";

            for (int i = 1; i <= iterations; i++)
            {
                result += input;
            }

            return result;

        }
    }
}
