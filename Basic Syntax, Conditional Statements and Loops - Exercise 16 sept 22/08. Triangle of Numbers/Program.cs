using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <= n; i++)
            {
                int tempNum = i;
                while (counter < tempNum)
                {
                    Console.Write($"{tempNum} ");
                    counter++;
                }
                Console.Write("\n");
                counter = 0;
            }
        }
    }
}
