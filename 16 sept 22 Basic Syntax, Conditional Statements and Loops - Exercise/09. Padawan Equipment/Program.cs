using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            double costEquipment;

            double lightsabers = lightsabersPrice * students + Math.Ceiling(students * 0.1)* lightsabersPrice;
            double belts = beltsPrice * students - students/6 * beltsPrice;
            double robes = robesPrice * students;
            costEquipment = lightsabers + robes + belts;
            
            if (costEquipment <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {costEquipment:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(costEquipment - money):F2}lv more.");
            }

        }
    }
}
