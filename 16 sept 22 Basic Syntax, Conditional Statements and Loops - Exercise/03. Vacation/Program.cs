using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPpl = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if (typeOfGroup == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45 * countPpl;
                }
                else if (day == "Saturday")
                {
                    price = 9.80 * countPpl;
                }
                else if (day == "Sunday")
                {
                    price = 10.46 * countPpl;
                }

                if (countPpl >= 30)
                {
                    price -= price * 0.15;
                }
            }

            if (typeOfGroup == "Business")
            {
                if (day == "Friday")
                {
                    if (countPpl >= 100)
                    {
                        countPpl -= 10;
                    }
                    price = 10.90 * countPpl;
                }
                else if (day == "Saturday")
                {
                    if (countPpl >= 100)
                    {
                        countPpl -= 10;
                    }
                    price = 15.60 * countPpl;
                }
                else if (day == "Sunday")
                {
                    if (countPpl >= 100)
                    {
                        countPpl -= 10;
                    }
                    price = 16 * countPpl;
                }
            }

            if (typeOfGroup == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15 * countPpl;
                }
                else if (day == "Saturday")
                {
                    price = 20 * countPpl;
                }
                else if (day == "Sunday")
                {
                    price = 22.50 * countPpl;
                }

                if (countPpl >= 10 && countPpl <= 20)
                {
                    price -= price * 0.05;
                }
            }

            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
