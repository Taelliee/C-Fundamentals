using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = 1;
            while (multiplier <= 10)
            {
                Console.WriteLine($"{n} X {multiplier} = {n*multiplier}");
                multiplier += 1;
            }

        }
    }
}
