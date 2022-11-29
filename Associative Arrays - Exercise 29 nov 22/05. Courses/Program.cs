using System;
using System.Collections.Generic;

namespace _05._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split(" : ");

                string course = input[0];
                string student = input[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                }
                courses[course].Add(student);
            }

            foreach (var course in courses)
            {
                List<string> students = course.Value;

                Console.WriteLine($"{course.Key}: {students.Count}");
                
                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
