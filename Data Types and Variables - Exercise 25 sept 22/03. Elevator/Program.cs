using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int courses;

            if (n / p == 0)
            {
                Console.WriteLine("All the persons fit inside in the elevator. \nOnly one course is needed.");
            }
            else if (n % p == 0)
            {
                courses = n / p;
                Console.WriteLine($"{courses} courses * {p} people");
            }
            else
            {
                courses = n / p;
                int personsLeft = n % p;
                Console.WriteLine($"{courses} courses * {p} people \n+ 1 course * {personsLeft} persons");
            }

        }
    }
}
