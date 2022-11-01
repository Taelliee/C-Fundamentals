using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            //A train has n number of wagons. On the next n lines,
            //receive the number of people getting on each wagon.
            //Print out the number of passengers in each wagon
            //and the total number of passengers on the train.

            int wagons = int.Parse(Console.ReadLine());
            int[] passengers = new int[wagons];
            int sum = 0;

            for (int i = 0; i < wagons; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                sum += passengers[i];
            }

            Console.WriteLine(string.Join(" ", passengers));
            Console.WriteLine(sum);
        }
    }
}
