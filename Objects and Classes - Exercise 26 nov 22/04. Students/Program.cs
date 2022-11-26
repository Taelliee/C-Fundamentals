using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> studentsList = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Student currStudent = new Student(firstName, lastName, grade);
                studentsList.Add(currStudent);
            }
            List<Student> desceningStudents = studentsList
                .OrderByDescending(x => x.Grade)
                .ToList();

            foreach (Student student in desceningStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
