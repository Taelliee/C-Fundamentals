using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Receives an array and several rotations that you have to perform.
            //The rotations are done by moving the first element of the array from the front to the back.
            //Prints the resulting array.

            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int r = 1; r <= rotations % arr.Length; r++)
            {
                int firstElement = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    arr[i - 1] = arr[i];
                }
                arr[arr.Length - 1] = firstElement;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
