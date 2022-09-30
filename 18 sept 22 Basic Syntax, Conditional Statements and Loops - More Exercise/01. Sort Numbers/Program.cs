using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if ((a > b) && (a > c))
            {
                if (b > c)
                {
                    Console.WriteLine("{0}\n{1}\n{2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0}\n{1}\n{2}", a, c, b);
                }
            }
            else if ((b > a) && (b > c))
            {
                if (a > c)
                {
                    Console.WriteLine("{0}\n{1}\n{2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0}\n{1}\n{2}", b, c, a);
                }
            }
            else if ((c > a) && (c > b))
            {
                if (a > b)
                {
                    Console.WriteLine("{0}\n{1}\n{2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0}\n{1}\n{2}", c, b, a);
                }
            }
        }
    }
}
