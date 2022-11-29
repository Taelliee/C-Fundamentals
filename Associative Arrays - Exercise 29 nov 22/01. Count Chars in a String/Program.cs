using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that counts all characters in a string, except for space (' ')
            Dictionary<char, int> letters = new Dictionary<char, int>();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currLetter = input[i];
                if (currLetter == ' ')
                {
                    continue;
                }

                if (!letters.ContainsKey(currLetter))
                {
                    letters.Add(currLetter, 0);
                }
                letters[currLetter]++;
            }
            
            foreach (var (k, v) in letters)
            {
                Console.WriteLine($"{k} -> {v}");
            }
        }
    }
}
