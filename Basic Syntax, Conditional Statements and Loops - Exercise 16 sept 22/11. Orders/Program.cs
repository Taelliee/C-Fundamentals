using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double pricePerCapsule = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int countCapsules = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            double tempPrice = ((days * countCapsules) * pricePerCapsule);

            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"The price for the coffee is: ${tempPrice:F2}");
                    totalPrice += tempPrice; continue;
                }
                
                pricePerCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                countCapsules = int.Parse(Console.ReadLine());
                tempPrice = (days * countCapsules) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${tempPrice:F2}");
                totalPrice += tempPrice;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
