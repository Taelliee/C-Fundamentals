using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double bases = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(PowerUp(bases, power)); 
        }

        static double PowerUp(double bases, int power)
        {
            double result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= bases;
            }
            return result;
        }
    }
}
