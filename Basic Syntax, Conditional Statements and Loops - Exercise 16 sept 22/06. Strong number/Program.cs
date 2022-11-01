using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string value = num.ToString();
            int length = value.Length;
            int fact = 1;
            int tempNum;
            int sum = 0;
            while (num != 0)
            {
                while (length > 0)
                {
                    tempNum = num%10;
                     
                    while (tempNum > 0)
                    {
                        fact *= tempNum;
                        tempNum--;
                    }
                    num /= 10;
                    sum += fact;
                    fact = 1;
                    length --;
                }
            }
            
            if (sum.ToString() == value)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
