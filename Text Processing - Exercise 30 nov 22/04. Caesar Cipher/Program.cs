using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            //Returns an encrypted version of the same text by shifting
            //each character three positions forward

            string text = Console.ReadLine();
            StringBuilder encryptedText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                int charValue = text[i] + 3;
                encryptedText.Append((char) charValue);
            }
            Console.WriteLine(encryptedText);
        }
    }
}
