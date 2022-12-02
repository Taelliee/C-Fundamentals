using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";
            Regex regex = new Regex(pattern);
            List<Match> matches = new List<Match>();

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                bool isAMatch = regex.IsMatch(input);
                if (isAMatch)
                {
                    matches.Add(regex.Match(input));
                }
            }

            Console.WriteLine("Bought furniture:");

            double moneySpent = 0.0;
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups["name"].Value);
                double currPrice = double.Parse(match.Groups["price"].Value);
                int currQuantity = int.Parse(match.Groups["quantity"].Value);
                moneySpent += currPrice * currQuantity;
            }

            Console.WriteLine($"Total money spend: {moneySpent:F2}");
        }
    }
}
