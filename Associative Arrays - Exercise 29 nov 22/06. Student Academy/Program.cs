using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> gradeBook = new Dictionary<string, List<double>>();
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string studentName = input[0];
                double grade = double.Parse(Console.ReadLine());

                if (!gradeBook.ContainsKey(studentName))
                {
                    gradeBook.Add(studentName, new List<double>());
                }
                gradeBook[studentName].Add(grade);
            }

            foreach (var item in gradeBook)
            {
                string studentName = item.Key;
                List<double> grades = item.Value;
                if (grades.Average() >= 4.50)
                {
                    Console.WriteLine($"{studentName} -> {grades.Average():f2}");
                }
            }
        }
    }
}
