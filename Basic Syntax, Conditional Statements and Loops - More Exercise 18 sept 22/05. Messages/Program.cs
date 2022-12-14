using System;
using System.Linq;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)

        {
		//offset = (main digit - 2) * 3
		//letter index = (offset + digit length - 1)

            int n = int.Parse(Console.ReadLine());
            string letters = string.Empty;
            string input;

		for (int i = 0; i < n; i++)
		{
                input = Console.ReadLine();
                int mainDigit = int.Parse(input[0].ToString());

                if (mainDigit == 0)
                {
                    letters += " "; continue;
		}

		int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
		}

                int letterIndex = (offset + input.Length - 1);
                letters += (char)(97 + letterIndex);
		}

            Console.WriteLine(letters);
        }
    }
}
