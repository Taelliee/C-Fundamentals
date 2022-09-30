using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            byte lines = byte.Parse(Console.ReadLine());
            bool isBalanced = true;
            int counterO = 0;
            int counterC = 0;

            while (lines > 0)
            {
                string input = Console.ReadLine();
                if (input == "(" )
                {
                    counterO++;
                }
                if (input == ")")
                {
                    counterC++;
                    if (counterO - counterC != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                lines--;
            }
            
            if (counterC != counterO)
            {
                isBalanced = false;
            }
            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
