using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            //possible operators are: /, *, + and -

            Console.WriteLine(Calculate(firstNum, @operator, secondNum));
        }

        static double Calculate(int firstNum, char @operator, int secondNum)
        {
            double result = 0;
            switch (@operator)
            {
                case '/':
                    result = firstNum / secondNum;
                    break;
                case '*':
                    result = firstNum * secondNum;
                    break;
                case '+':
                    result = firstNum + secondNum;
                    break;
                case '-':
                    result = firstNum - secondNum;
                    break;
            }
            return result;
        }
    }
}
