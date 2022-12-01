using System;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads the path to a file and subtracts the file name and its extension

            string[] file = Console.ReadLine()
                .Split(@"\");

            string fileNameAndExtension = file[^1];
            string[] strArr = fileNameAndExtension.Split(".");

            Console.WriteLine($"File name: {strArr[0]}");
            Console.WriteLine($"File extension: {strArr[1]}");
        }
    }
}
