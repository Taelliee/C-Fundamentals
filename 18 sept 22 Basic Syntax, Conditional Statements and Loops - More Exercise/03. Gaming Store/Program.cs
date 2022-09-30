using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            double price = 0;
            double cost = 0;

            while (game != "Game Time")
            {
                
                switch (game)
                {
                    case "OutFall 4":
                        price = 39.99; break;
                    case "CS: OG":
                        price = 15.99; break;
                    case "Zplinter Zell":
                        price = 19.99; break;
                    case "Honored 2":
                        price = 59.99; break;
                    case "RoverWatch":
                        price = 29.99; break;
                    case "RoverWatch Origins Edition":
                        price = 39.99; break;
                }
                if (currentBalance < price)
                {
                    Console.WriteLine("Too Expensive");
                    game = Console.ReadLine(); continue;
                }
                
                switch (game)
                {
                    case "OutFall 4":
                    case "CS: OG":
                    case "Zplinter Zell":
                    case "Honored 2":
                    case "RoverWatch":
                    case "RoverWatch Origins Edition":
                        Console.WriteLine($"Bought {game}");
                        currentBalance -= price;
                        cost += price;
                        if (currentBalance <= 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        game = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        game = Console.ReadLine();
                        break;
                }
                
            }
            if (game == "Game Time")
            {
                Console.WriteLine($"Total spent: ${cost:F2}. Remaining: ${currentBalance:F2}");
            }
        }
    }
}
