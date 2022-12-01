using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            string str1 = input[0];
            string str2 = input[1];

            int sumChars = GetSum(str1, str2);
            Console.WriteLine(sumChars);
        }

        private static int GetSum(string str1, string str2)
        {
            string shorter = str1;
            string longer = str2;

            if (str2.Length < str1.Length)
            {
                shorter = str2;
                longer = str1;
            }

            int sumChars = 0;
            for (int i = 0; i < shorter.Length; i++)
            {
                sumChars += str1[i] * str2[i];
            }
            for (int i = shorter.Length; i < longer.Length; i++)
            {
                sumChars += longer[i];
            }

            return sumChars;
        }
    }
}
