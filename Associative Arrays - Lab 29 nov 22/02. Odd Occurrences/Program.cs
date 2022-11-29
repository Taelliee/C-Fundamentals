using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that extracts all elements from a given sequence of words
            //that are present in it an odd number of times (case-insensitive)
            //Java C# PHP PHP JAVA C java --> java c# c 

            string[] elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> elementsOcc = new Dictionary<string, int>();

            foreach (string element in elements)
            {
                string elLowerCase = element.ToLower();
                if (!elementsOcc.ContainsKey(elLowerCase))
                {
                    elementsOcc.Add(elLowerCase, 0);
                }
                elementsOcc[elLowerCase]++;
            }
            foreach (var element in elementsOcc)
            {
                if (element.Value % 2 != 0)
                {
                    Console.Write(element.Key + " ");
                }
            }
        }
    }
}
