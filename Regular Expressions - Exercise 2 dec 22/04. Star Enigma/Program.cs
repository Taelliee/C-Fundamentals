using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regexDecrypt = new Regex(@"[SsTtAaRr]");
            Regex regexMessage = new Regex(@"@(?<planet>[A-Za-z]+)([^@\-!:>]*):(?<population>\d+)([^@\-!:>]*)!(?<attack>A|D)!([^@\-!:>]*)\->(?<soldiers>\d+)");

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            
            int n = int.Parse(Console.ReadLine());

            string input;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                int key = regexDecrypt.Matches(input).Count;

                StringBuilder decryptedWord = new StringBuilder();
            
                for (int x = 0; x < input.Length; x++)
                {
                    char oldValue = input[x];
                    int newValue = oldValue - key;
                    decryptedWord.Append((char)newValue);
                }

                Match match = regexMessage.Match(decryptedWord.ToString());
                if (match.Success == false)
                {
                    continue;
                }

                if (match.Groups["attack"].Value == "A")
                {
                    attackedPlanets.Add(match.Groups["planet"].Value);
                }
                else
                {
                    destroyedPlanets.Add(match.Groups["planet"].Value);
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
            
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
