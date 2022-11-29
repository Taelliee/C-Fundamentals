using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> companiesInfo = new Dictionary<string, HashSet<string>>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split(" -> ");

                string companyName = input[0];
                string iD = input[1];

                if (!companiesInfo.ContainsKey(companyName))
                {
                    companiesInfo.Add(companyName, new HashSet<string>());
                }
                companiesInfo[companyName].Add(iD);
            }

            foreach (var item in companiesInfo)
            {
                Console.WriteLine(item.Key);

                foreach (var iD in companiesInfo[item.Key])
                {
                    Console.WriteLine($"-- {iD}");
                }
            }

        }
    }
}
