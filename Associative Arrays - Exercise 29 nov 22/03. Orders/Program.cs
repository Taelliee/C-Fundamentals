using System;
using System.Collections.Generic;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            string command ;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] input = command.Split();

                string name = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, new List<double>());
                    products[name].Add(0);
                    products[name].Add(0);
                }
                products[name][0] = price;
                products[name][1] += quantity;
            }

            foreach (KeyValuePair<string, List<double>> item in products)
            {
                string product = item.Key;
                double price = item.Value[0];
                double quantity = item.Value[1];

                Console.WriteLine($"{product:f2} -> {(price * quantity):f2}");
            }
        }
    }
}
