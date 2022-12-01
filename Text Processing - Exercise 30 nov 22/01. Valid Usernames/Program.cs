using System;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] users = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            //A valid username:
            //  has length between 3 and 16 characters
            //  contains only letters, numbers, hyphens and underscore

            foreach (string currUser in users)
            {
                if (currUser.Length > 3 && currUser.Length <= 16)
                {
                    if (IsUserNameValid(currUser))
                    {
                        Console.WriteLine(currUser);
                    }
                }
            }
        }
        
        static bool IsUserNameValid(string currUser)
        {
            foreach (char currChar in currUser)
            {
                if (!(char.IsLetterOrDigit(currChar) || currChar == '-' || currChar == '_'))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
