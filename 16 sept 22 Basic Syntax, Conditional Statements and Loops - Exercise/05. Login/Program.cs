using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            // letter = text[i]
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            int length = username.Length;
            int counter = 0;
            string reverseUsername = "";

            while (length > 0)
            {
                reverseUsername += username[length-1];
                length--;
            }

            while (true)
            {
                if (password == reverseUsername)
                {
                    Console.WriteLine($"User {username} logged in."); break;
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"User {username} blocked!"); break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                password = Console.ReadLine();
                counter++;
            }
            
        }
    }
}
