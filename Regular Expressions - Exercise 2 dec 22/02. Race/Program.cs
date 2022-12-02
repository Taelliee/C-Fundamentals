using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (string participant in participants)
            {
                dict.Add(participant, 0);
            }

            string pattern = @"[^A-Za-z]";
            Regex regexName = new Regex(pattern);
            Regex regexKM = new Regex(@"\d");

            string input;
            int allKM;
            while ((input = Console.ReadLine()) != "end of race")
            {
                allKM = 0;

                MatchCollection distanceKM = regexKM.Matches(input);
                foreach (var km in distanceKM)
                {
                    allKM += int.Parse(km.ToString());
                }

                input = regexName.Replace(input, string.Empty);

                if (!dict.ContainsKey(input))
                {
                    continue;
                }

                dict[input] += allKM;
            }
            
            var orderedDict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            int count = 0;
            foreach (var kvp in orderedDict)
            {
                if (count == 0)
                {
                    Console.WriteLine($"1st place: {kvp.Key}");
                }
                else if (count == 1)
                {
                    Console.WriteLine($"2nd place: {kvp.Key}");
                }
                else if (count == 2)
                {
                    Console.WriteLine($"3rd place: {kvp.Key}");
                }
                else if (count == 3)
                {
                    break;
                }
                count++;
            }
        }
    }
}
