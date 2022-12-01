using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(key))
            {
                int keyIndex = text.IndexOf(key);
                text = text.Remove(keyIndex, key.Length);
            }

            Console.WriteLine(text);
        }
    }
}
