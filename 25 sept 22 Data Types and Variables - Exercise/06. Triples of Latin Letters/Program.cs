using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (char a = (char)97; a < (char)97 + n; a++)
            {
                for (char b = (char)97; b < (char)97 + n; b++)
                {
                    for (char c = (char)97; c < (char)97 + n; c++)
                    {
                        Console.WriteLine($"{a}{b}{c}");
                    }
                }
            }
        }
    }
}
