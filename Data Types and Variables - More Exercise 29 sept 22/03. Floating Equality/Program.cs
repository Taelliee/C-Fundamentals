using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1 = float.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine());
            bool isTrue = false;

            if (n1 < 0 && n2 > 0|| n2 < 0 && n1 > 0)
            {
                Math.Abs(n1);
                Math.Abs(n2);
                if (n1 + n2 < 0.000009)
                {
                    isTrue = true;
                }
            }
            else if (n1 == n2)
            {
                isTrue = true;
            }
            Console.WriteLine(isTrue);
        }
    }
}
