using System;

namespace _01._Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {
            double experience = double.Parse(Console.ReadLine());
            int battles = int.Parse(Console.ReadLine());
            int battlesCount = 0;

            for (int i = 1; i <= battles; i++)
            {
                double input = double.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    input += 0.15 * input;
                }
                else if (i % 5 == 0)
                {
                    input -= 0.1 * input;
                }
                else if (i % 15 == 0)
                {
                    input += 0.05 * input;
                }
                battlesCount++;
                experience -= input;

                if (experience <= 0)
                {
                    break;
                }
            }

            if (experience <= 0)
            {

                Console.WriteLine($"Player successfully collected his needed experience for {battlesCount} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {experience:F2} more needed.");
            }
        }
    }
}
