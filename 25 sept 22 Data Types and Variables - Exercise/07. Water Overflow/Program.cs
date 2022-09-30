using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //water tank with a capacity of 255 liters
            byte capacity = 255;
            byte n = byte.Parse(Console.ReadLine());
            byte litersPoured = 0;

            for (int i = 0; i < n; i++)
            {
                short liters = short.Parse(Console.ReadLine());
                if (capacity - liters < 0)
                {
                    Console.WriteLine("Insufficient capacity!"); continue;
                }
                
                capacity -= (byte)liters;
                litersPoured += (byte)liters;
            }
            Console.WriteLine(litersPoured);
        }
    }
}
