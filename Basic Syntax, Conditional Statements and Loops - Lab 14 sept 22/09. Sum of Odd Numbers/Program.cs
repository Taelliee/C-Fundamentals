using System;

namespace _9._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(a);
                sum += a;
                a += 2;
                    
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
