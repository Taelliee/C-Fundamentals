using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                if (char.IsDigit(currChar))
                {
                    digits.Append(currChar);
                }
                else if (char.IsLetter(currChar))
                {
                    letters.Append(currChar);
                }
                else
                {
                    others.Append(currChar);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
