using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] input = Console.ReadLine().Split(' ');

            int bombNumber = int.Parse(input[0]);
            int power = int.Parse(input[1]);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    numbers[i] = 0;

                    for (int x = i; x >= i - power; x--)
                    {
                        if (x >= numbers.Count || x < 0)
                        {
                            break;
                        }

                        numbers[x] = 0;
                    }

                    for (int x = i; x <= i + power; x++)
                    {
                        if (x >= numbers.Count || x < 0)
                        {
                            break;
                        }

                        numbers[x] = 0;
                    }
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
