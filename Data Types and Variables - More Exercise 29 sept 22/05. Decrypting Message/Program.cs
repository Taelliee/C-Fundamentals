using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());
            byte lines = byte.Parse(Console.ReadLine());
            string word = String.Empty;

            for (int x = 0; x < lines; x++)
            {
                char letter = char.Parse(Console.ReadLine());
                letter += (char)key;
                word += letter;
            }
            Console.WriteLine(word);

        }
    }
}
