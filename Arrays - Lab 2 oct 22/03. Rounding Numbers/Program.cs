using System;
using System.Linq;


namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read an array of real numbers (space separated),
            //round them in "away from 0" style and print the output

            double[] n = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine($"{n[i]} => {(int)Math.Round(n[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
