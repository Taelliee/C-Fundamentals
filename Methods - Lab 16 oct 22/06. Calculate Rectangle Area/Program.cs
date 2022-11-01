using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //A method that calculates and returns the area of a rectangle

            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = GetAreaRectangle(a, h);
            Console.WriteLine(area);
        }
        static double GetAreaRectangle(double a, double h)
        {
            return (a * h);
        }
    }
}
