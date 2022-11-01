using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //reads positive integers until it receives the "END" command
            //for each number, prints whether the number is a palindrome or not (323, 1001)
            string input = Console.ReadLine();

            while (input != "END")
            {
                bool isPalindrome = false;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == input[input.Length-1-i])
                    {
                        isPalindrome = true;
                    }
                    else
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                Console.WriteLine(isPalindrome.ToString().ToLower());
                input = Console.ReadLine();
            }
        }
    }
}
