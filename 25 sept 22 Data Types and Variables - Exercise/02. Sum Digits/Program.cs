using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int tempN = n;

            while (tempN > 0)
            {
                sum += tempN % 10;
                tempN /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
