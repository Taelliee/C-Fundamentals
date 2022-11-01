using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            //multiplies the sum of all even digits of a number
            //by the sum of all odd digits of the same number

            int input = Math.Abs(int.Parse(Console.ReadLine()));
            string stringValue = input.ToString();
            Console.WriteLine(GetMultipleOfEvenAndOdds(stringValue)); 
        }

        private static int GetSumOfOddDigits(string stringValue)
        {
            int sum = 0;
            for (int i = 0; i < stringValue.Length; i++)
            {
                int temp = int.Parse(stringValue[i].ToString());
                if (temp % 2 != 0)
                {
                    sum += temp;
                }
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(string stringValue)
        {
            int sum = 0;
            for (int i = 0; i < stringValue.Length; i++)
            {
                int temp = int.Parse(stringValue[i].ToString());
                if (temp % 2 == 0)
                {
                    sum += temp;
                }
            }
            return sum;
        }

        private static int GetMultipleOfEvenAndOdds(string input)
        {
            int result = GetSumOfEvenDigits(input) * GetSumOfOddDigits(input);
            return result;

        }
    }
}
