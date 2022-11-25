using System;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            Random random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int rndNumber = random.Next(0, input.Length);

                string currValue = input[i];
                string rndValue = input[rndNumber];

                input[i] = rndValue;
                input[rndNumber] = currValue;
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
