using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string[] currStudent = Console.ReadLine()
                    .Split();

                if (currStudent[0] == "end")
                {
                    break;
                }

                Student student = new Student();
                student.FirstName = currStudent[0];
                student.LastName = currStudent[1];
                student.Age = currStudent[2];
                student.HomeTown = currStudent[3];
                students.Add(student);
            }

            string town = Console.ReadLine();

            foreach (Student student in students)
            {
                if(town == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");

                }
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string HomeTown { get; set; }

    }
}
