using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            //a method that receives two characters and
            //prints all the characters between them according to ASCI

            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            if (a > b)
            {
                PrintCharacters(b, a);
            }
            else
            PrintCharacters(a, b);
        }

        static void PrintCharacters(char start, char end)
        {
            for (int i = start + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }

        }
    }
}
