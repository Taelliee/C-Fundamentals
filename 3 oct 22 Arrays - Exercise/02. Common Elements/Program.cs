using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints out all common elements in two arrays.
            //Compares the elements of the second array to the elements of the first.

            string[] arr1 = Console.ReadLine()
                .Split()
                .ToArray();
            string[] arr2 = Console.ReadLine()
                .Split()
                .ToArray();

            string a = "";
            
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int x = 0; x < arr1.Length; x++)
                {
                    if (arr2[i] == arr1[x])
                    {
                        a += arr2[i] + " "; continue;
                    }
                }
            }
            Console.WriteLine(a);
        }
    }
}
