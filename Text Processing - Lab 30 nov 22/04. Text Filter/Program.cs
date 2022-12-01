using System;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();
            foreach (string bannedWord in bannedWords)
            {
                string replacement = new string ('*', bannedWord.Length);
            //    for (int i = 0; i < bannedWord.Length; i++)
            //    {
            //        replacement += '*';
            //    }
                text = text.Replace(bannedWord, replacement);
            }
            Console.WriteLine(text);
        }
    }
}
