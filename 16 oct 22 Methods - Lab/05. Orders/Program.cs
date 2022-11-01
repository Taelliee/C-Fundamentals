using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculates price of an order: 
            // -- product:
            //coffee – 1.50;
            //water – 1.00;
            //coke – 1.40;
            //snacks – 2.00.
            // -- quantity

            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PrintPrice(product, quantity);
        }
        static void PrintPrice(string product, int quantity)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
            }
            Console.WriteLine($"{(price * quantity):f2}");
        }
    }
}
