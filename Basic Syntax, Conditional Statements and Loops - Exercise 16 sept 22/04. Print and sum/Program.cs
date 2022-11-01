using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            

            while (start != end)
            {
                Console.Write($"{start} ");
                sum += start;
                start++;
            }

            Console.WriteLine(end);
            Console.WriteLine($"Sum: {sum+end}");
        }
    }
}
