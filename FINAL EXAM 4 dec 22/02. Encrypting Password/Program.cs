using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Encrypting_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^(.*)>(?<digits>\d+)\|(?<lowercase>[a-z]+)\|(?<uppercase>[A-Z]+)\|(?<symbols>[^<>]+)<\1$");
            //there may be no symbols at the beginning and end
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (!regex.IsMatch(input))
                {
                    Console.WriteLine("Try another password!"); continue;
                }

                Match match = regex.Match(input);
                Encrypt(match);
            }
        }

        private static void Encrypt(Match match)
        {
            string digits = match.Groups["digits"].Value;
            string lowercase = match.Groups["lowercase"].Value;
            string uppercase = match.Groups["uppercase"].Value;
            string symbols = match.Groups["symbols"].Value;

            Console.WriteLine($"Password: {digits + lowercase + uppercase + symbols}");
        }
    }
}
