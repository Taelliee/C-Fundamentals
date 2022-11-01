using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reads an array of strings, reverses it, and prints its elements.
            //The input consists of a sequence of space-separated strings.

            var input = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < input.Length / 2; i++)
            {
                var oldInput = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = oldInput;
            }

            Console.WriteLine(string.Join(' ', input));
        }
    }
}
