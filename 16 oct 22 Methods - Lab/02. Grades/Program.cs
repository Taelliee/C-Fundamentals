using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method that receives a grade between
            //2.00 and 6.00 and prints the corresponding grade definition

            double grade = double.Parse(Console.ReadLine());
            string typeOfGrade = GetType(grade);
            Console.WriteLine(typeOfGrade);
        }

        static string GetType(double grade)
        {
            string typeOfGrade = "";
            if (grade < 3)
            {
                typeOfGrade = "Fail";
            }
            else if (grade < 3.50)
            {
                typeOfGrade = "Poor";
            }
            else if (grade < 4.50)
            {
                typeOfGrade = "Good";
            }
            else if (grade < 5.50)
            {
                typeOfGrade = "Very good";
            }
            else if (grade <= 6)
            {
                typeOfGrade = "Excellent";
            }
            return typeOfGrade;
        }
    }
}
