using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            var result = new StringBuilder();

            if (input == "0" || multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int remainder = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currNum = (int.Parse(input[i].ToString()));
                int currMultiplication = (currNum * multiplier + remainder);
                result.Insert(0, currMultiplication % 10 );
                remainder = currMultiplication / 10;
            }
            if (remainder > 0)
            {
                result.Insert(0, remainder);
            }
            Console.WriteLine(result);
        }
    }
}
