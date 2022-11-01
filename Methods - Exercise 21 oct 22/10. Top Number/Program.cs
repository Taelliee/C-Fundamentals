using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            PrintAllTopNumbers(num);
        }

        static void PrintAllTopNumbers(int end)
        {
            for (int i = 17; i <= end; i++)
            {
                if (AreDigitsDivisibleByEight(i) && HoldsAtLeastOneOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool HoldsAtLeastOneOddDigit(int num)
        {
            while (num != 0)
            {
                if ((num % 10) % 2 != 0)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }

        static bool AreDigitsDivisibleByEight(int num)
        {
            int sumDigits = 0;
            while (num != 0)
            {
                sumDigits += num % 10;
                num /= 10;
            }

            if (sumDigits % 8 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
