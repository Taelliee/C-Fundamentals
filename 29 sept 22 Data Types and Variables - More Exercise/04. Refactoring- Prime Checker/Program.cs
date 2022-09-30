using System;

namespace _04._Refactoring__Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int x = 2; x < i; x++)
                {
                    if (i % x == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                string isIt = isPrime.ToString();
                Console.WriteLine("{0} -> {1}", i, isIt.ToLower());
            }
        }
    }
}
