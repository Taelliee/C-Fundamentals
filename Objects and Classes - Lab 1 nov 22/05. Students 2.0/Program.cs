using System;
using System.Collections.Generic;

namespace _05._Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();

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

                if (!AreNamesUnique(studentsList, student.FirstName, student.LastName))
                {
                    FindAndReplaceDoppelGanger(student, studentsList, student.FirstName, student.LastName);
                }
                else
                {
                    studentsList.Add(student);
                }
            }

            string town = Console.ReadLine();

            foreach (Student student in studentsList)
            {
                if (town == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static void FindAndReplaceDoppelGanger(Student student, List<Student> studentsList, string firstName, string lastName)
        {
            foreach (Student studentSearch in studentsList)
            {
                if (firstName == studentSearch.FirstName && lastName == studentSearch.LastName)
                {
                    studentSearch.Age = student.Age;
                    studentSearch.HomeTown = student.HomeTown;
                }
            }
        }

        static bool AreNamesUnique(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (firstName == student.FirstName && lastName == student.LastName)
                {
                    return false;
                }
            }
            return true;
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
