using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter a number in range 1-7 and print out the word
            //representing it or "Invalid Day!".
            //Use an array of strings.

            string[] dayOfWeek = new string[7] { 
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"};

            int input = int.Parse(Console.ReadLine());

            if (input < 1 || input > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(dayOfWeek[input - 1]);
            }

        }
    }
}
