using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Nuts" with a price of 2.0
            //"Water" with a price of 0.7
            //"Crisps" with a price of 1.5
            //"Soda" with a price of 0.8
            //"Coke" with a price of 1.0

            //0.1, 0.2, 0.5, 1 and 2 -- valid coins
            string input = Console.ReadLine();
            double price;
            double money = 0;

            while (input != "Start")
            {
                if (!(input == "0.1" || input == "0.2" || input == "0.5" || input == "1" || input == "2"))
                {
                    Console.WriteLine($"Cannot accept {input}");
                    input = "0";
                }
                money += Convert.ToDouble(input);
                input = Console.ReadLine();
                
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                if (input == "Nuts")
                {
                    price = 2;
                }
                else if (input == "Water")
                {
                    price = 0.7;
                }
                else if (input == "Crisps")
                {
                    price = 1.5;
                }
                else if (input == "Soda")
                {
                    price = 0.8;
                }
                else if (input == "Coke")
                {
                    price = 1;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    input = Console.ReadLine();
                    continue;
                }
                
                if (money < price)
                {
                    Console.WriteLine("Sorry, not enough money");
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Purchased {input.ToLower()}");
                    money -= price;
                    input = Console.ReadLine();
                }
            }
            
            if (money >= 0.00)
            {
                Console.WriteLine($"Change: {money:F2}");
            }
            else
            {
                Console.WriteLine($"Change: 0.00");
            }
        }
    }
}
