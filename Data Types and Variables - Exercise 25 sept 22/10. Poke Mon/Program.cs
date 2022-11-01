using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int count = 0;
            int n = N;

            while (n >= M)
            {
                count++;
                n -= M;

                if (n == N/2 && Y != 0)
                {
                    n /= Y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
