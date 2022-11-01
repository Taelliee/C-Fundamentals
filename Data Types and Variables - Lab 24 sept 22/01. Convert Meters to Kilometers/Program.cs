using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            float km = m / 1000.0f;
            
            Console.WriteLine($"{km:f2}");
        }
    }
}
