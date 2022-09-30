﻿using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            string maxModel = "";
            double maxVolume = 0;
            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(r, 2) * h;
                
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    maxModel = model;
                }
            }
            Console.WriteLine(maxModel);
        }
    }
}
