using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            //a method that receives a single string
            //and prints out the number of vowels contained in it

            string input = Console.ReadLine();
            Console.WriteLine(GetNumberOfVowels(input)); 

        }

        static int GetNumberOfVowels(string input)
        {
            int counter = 0;
            char[] vowels = new char[] { 'a', 'i', 'u', 'e', 'o', 'y' };
            foreach (char letter in input.ToLower())
            {
                if (vowels.Contains(letter))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
