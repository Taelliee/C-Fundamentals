using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double factorielNum1 = GetFactotiel(num1);
            double factorielNum2 = GetFactotiel(num2);

            Console.WriteLine($"{(factorielNum1/factorielNum2):f2}");
        }

        static double GetFactotiel(int num)
        {
            double sum = 1.00;
            for (int i = 1; i <= num; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
