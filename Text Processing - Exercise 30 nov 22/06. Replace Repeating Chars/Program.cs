using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reads a string from the console and replaces any sequence of the same letter
            //with a single corresponding letter.

            string input = Console.ReadLine();
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i+1])
                {
                    Console.Write(input[i]);
                }
            }
            Console.Write(input[^1]);
        }
    }
}
