using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (true)
            {
                int input = Console.Read();
                counter++;

                if (counter)
                {
                    counter = 0;
                }
            }
        }
    }
}
