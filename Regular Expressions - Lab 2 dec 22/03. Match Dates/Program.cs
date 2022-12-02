using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b(?<day>\d{2})(.|/|-])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            //неименуваните групи застават пред именуваните --> 1 група
            //нулевата група съдържа целия match
            
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
