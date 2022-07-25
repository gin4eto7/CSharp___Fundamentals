using System;

namespace _11MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string operat = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(num1, operat, num2));
        }

        static int Calculate (int num1 , string opert, int num2)
        {
            int result = 0;
            if(opert == "+")
            {
                result = num1 + num2;
            }
            else if(opert == "-")
            {
                result = num1 - num2;
            }
            else if(opert == "*")
            {
                result = num1 * num2;
            }
            else if(opert == "/")
            {
                result = num1 / num2;
            }

            return result;
        }
    }
}
