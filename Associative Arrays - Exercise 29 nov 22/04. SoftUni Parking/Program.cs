using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingRegister = new Dictionary<string, string>();
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = input[0];
                string user = input[1];

                if (command == "register")
                {
                    string licensePlateNumber = input[2];
                    if (parkingRegister.ContainsKey(user))
                    {
                        string registeredPlateNumber = parkingRegister[user];
                        Console.WriteLine($"ERROR: already registered with plate number {registeredPlateNumber}");
                    }
                    else
                    {
                        parkingRegister.Add(user, licensePlateNumber);
                        Console.WriteLine($"{user} registered {licensePlateNumber} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (parkingRegister.ContainsKey(user))
                    {
                        parkingRegister.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                }
            }

            foreach (var parkingLot in parkingRegister)
            {
                string username = parkingLot.Key;
                string licensePlateNumber = parkingLot.Value;

                Console.WriteLine($"{username} => {licensePlateNumber}");
            }
        }
    }
}
