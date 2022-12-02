using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regexCustomer = new Regex(@"%(?<customer>[A-Z][a-z]+)%");
            Regex regexProduct = new Regex(@"<(?<product>\w+)>");
            Regex regexCount = new Regex(@"\|(?<count>\d+)\|");
            Regex regexPrice = new Regex(@"(?<price>\d+(\.\d+)?)\$");
            //Regex regex = new Regex(@"%(?<customer>[A-Z][a-z]+)%[^\|\$\%\.]*?<(?<product>\w+)>[^\|\$\%\.]*?\|(?<count>\d+)\|[^\|\$\%\.]*?(?<price>\d+(\.\d+)?)\$")
            double income = 0.0;
            string input;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                if (!(regexCustomer.IsMatch(input) && regexProduct.IsMatch(input) && regexCount.IsMatch(input) && regexPrice.IsMatch(input)))
                {
                    continue;
                }

                string customer = regexCustomer.Match(input).Groups["customer"].ToString();
                string product = regexProduct.Match(input).Groups["product"].ToString();
                int count = int.Parse(regexCount.Match(input).Groups["count"].ToString());
                double price = double.Parse(regexPrice.Match(input).Groups["price"].ToString());

                income += (count * price);

                Console.WriteLine($"{customer}: {product} - {(count * price):F2}");
            }
            Console.WriteLine($"Total income: {income:F2}");
        }
    }
}
