using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            //a program that checks if a given password is valid

            string input = Console.ReadLine();

            if (!BetweenSixAndTen(input))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!OnlyLettersAndDigits(input))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!AtLeastTwoDigits(input))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (AtLeastTwoDigits(input) && OnlyLettersAndDigits(input) && BetweenSixAndTen(input))
            {
                Console.WriteLine("Password is valid");
            }
            
        }

        static bool AtLeastTwoDigits(string input)
        {
            int cntDigits = 0;
            foreach (char letter in input)
            {
                if (Char.IsDigit(letter))
                {
                    cntDigits++;
                }
            }
            if (cntDigits < 2)
            {
                return false;
            }
            return true;
        }

        static bool OnlyLettersAndDigits(string input)
        {
            foreach (char letter in input)
            {
                if (!Char.IsLetterOrDigit(letter))
                {
                    return false;
                }
            }
            return true;
        }

        static bool BetweenSixAndTen(string input)
        {
            if (!(input.Length >= 6 && input.Length <= 10))
            {
                return false;
            }
            return true;
        }
    }
}
