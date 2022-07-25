using System;

namespace _03Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            PrintResult(command, num1, num2);
        }

        
            

        private static void PrintResult (string command, int num1, int num2)
        {
            if(command == "add")
            {
                Console.WriteLine(OddCommand(command, num1, num2));
            }
            else if(command == "multiply")
            {
                Console.WriteLine(MultiplyCommand(command, num1, num2));
            }
            else if(command == "subtract")
            {
                Console.WriteLine(SubtractCommand(command, num1, num2));
            }
            else if(command == "divide")
            {
                Console.WriteLine(DivideCommand(command, num1, num2));
            }
        }

        private static int OddCommand(string command, int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        private static int MultiplyCommand (string command, int num1, int num2)
        {
            int sum = num1 * num2;
            return sum;
        }

        private static int SubtractCommand (string command, int num1, int num2)
        {
            int sum = num1 - num2;
            return sum;
        }

        private static double DivideCommand(string comman, int num1, int num2)
        {
            double sum = num1 / num2;
            return sum;
        }

    }

}
