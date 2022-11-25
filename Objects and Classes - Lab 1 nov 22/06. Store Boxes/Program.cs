using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> storage = new List<Box>();

            while (true)
            {
                string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                if (input[0] == "end")
                {
                    break;
                }

                Item item = new Item();
                Box box = new Box();
                box.Item = new Item();
                box.SerialNumber = int.Parse(input[0]);
                box.Item.Name = input[1];
                box.ItemQuantity = int.Parse(input[2]);
                box.Item.Price = double.Parse(input[3]);
                box.PricePerBox = box.ItemQuantity * box.Item.Price;

                storage.Add(box);
            }

            foreach (Box box in storage.OrderByDescending(x => x.PricePerBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PricePerBox:f2}");
            }
        } 
    }

    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PricePerBox {get; set;}
    }
}
