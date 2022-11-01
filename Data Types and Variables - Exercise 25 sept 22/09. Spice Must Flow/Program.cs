using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            
            if (yield < 100)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
                return;
            }
            
            int totalAmount = yield - 26;
            int counter = 1;
            yield -= 10;

            while (yield >= 100)
            {
                totalAmount += yield;
                if (totalAmount - 26 >= 0)
                {
                    totalAmount -= 26;
                }
                counter++;
                yield -= 10;
            }
            Console.WriteLine(counter);
            Console.WriteLine(totalAmount-26);
        }
    }
}
