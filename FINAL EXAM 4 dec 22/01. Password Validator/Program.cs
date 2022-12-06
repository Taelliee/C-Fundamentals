using System;
using System.Text.RegularExpressions;

namespace _01._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            
            string input;
            while ((input = Console.ReadLine()) != "Complete")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currCommand = commands[0];

                if (currCommand == "Make")
                {
                    int index = int.Parse(commands[2]);
                    //check if the index is valid
                    if (!(index < 0 || index > password.Length - 1))
                    {
                        password = Make(password, commands, index);
                        Console.WriteLine(password);
                    }
                }
                else if (currCommand == "Insert")
                {
                    int index = int.Parse(commands[1]);
                    string currChar = commands[2];

                    if (!(index < 0 || index > password.Length - 1))
                    {
                        password = password.Insert(index, currChar);
                        Console.WriteLine(password);
                    }
                }
                else if (currCommand == "Replace")
                {
                    if (password.Contains(commands[1]))
                    {
                        char currChar = char.Parse(commands[1].ToString());
                        int value = int.Parse(commands[2]);
                        int newSymbol = (int)currChar + value;

                        password = password.Replace(currChar, (char)newSymbol);
                        Console.WriteLine(password);
                    }
                }
                else if (currCommand == "Validation")
                {
                    Validation(password);
                }
            }
        }

        static void Validation(string password)
        {
            Regex regexEightChars = new Regex(@".{8,}");
            Regex regexOnlyWordChars = new Regex(@"^\w+$");
            Regex regexUppercase = new Regex(@"[A-Z]");
            Regex regexLowercase = new Regex(@"[a-z]");
            Regex regexDigit = new Regex(@"[0-9]");

            if (!regexEightChars.IsMatch(password))
            {
                Console.WriteLine("Password must be at least 8 characters long!");
            }
            if (!regexOnlyWordChars.IsMatch(password))
            {
                Console.WriteLine("Password must consist only of letters, digits and _!");
            }
            if (!regexUppercase.IsMatch(password))
            {
                Console.WriteLine("Password must consist at least one uppercase letter!");
            }
            if (!regexLowercase.IsMatch(password))
            {
                Console.WriteLine("Password must consist at least one lowercase letter!");
            }
            if (!regexDigit.IsMatch(password))
            {
                Console.WriteLine("Password must consist at least one digit!");
            }
        }

        static string Make(string password, string[] commands, int index) 
        {
            string upOrLow = commands[1];
            string currLetter = password.Substring(index, 1);

            if (upOrLow == "Upper")
            {
                return password.Replace(currLetter, currLetter.ToUpper());
            }

            return password.Replace(currLetter, currLetter.ToLower());
        }

    }
}
