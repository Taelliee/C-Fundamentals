using System;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                string number1 = "";
                string number2 = "";
                bool isNumber1 = true;
                
                for (int x = 0; x < input.Length; x++)
                {
                    if (input[x] == ' ')
                    {
                        isNumber1 = false; continue;
                    }
                    if (isNumber1)
                    {
                        number1 += input[x];
                    }
                    else
                    {
                        number2 += input[x];
                    }
                }
                long isBiggerNumber = long.Parse(number1);
                if (long.Parse(number1) < long.Parse(number2))
                {
                    isBiggerNumber = long.Parse(number2);
                }
                long sumOfDigits = 0;
                while (isBiggerNumber != 0)
                {
                    sumOfDigits += isBiggerNumber % 10;
                    isBiggerNumber /= 10;
                }
                Console.WriteLine(Math.Abs(sumOfDigits));
            }
        }
    }
}
