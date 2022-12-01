using System;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                string currWord = input[i];
                for (int x = 0; x < currWord.Length; x++)
                {
                    result += currWord;
                }
            }

            Console.WriteLine(result);
        }
    }
}
