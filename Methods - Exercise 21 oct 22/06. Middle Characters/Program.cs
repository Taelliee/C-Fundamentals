using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            //receives a single string
            //a method that prints the character found at its middle
            //if the length of the string is even, there are two middle characters

            string input = Console.ReadLine();

            MiddleCharacters(input);
        }

        static void MiddleCharacters(string input)
        {
            if (input.Length % 2 == 0)
            {
                Console.Write(input[(input.Length / 2) - 1]);
                Console.Write(input[input.Length/2]);
            }
            else
            {
                Console.WriteLine(input[input.Length/2]);
            }
        }
    }
}
