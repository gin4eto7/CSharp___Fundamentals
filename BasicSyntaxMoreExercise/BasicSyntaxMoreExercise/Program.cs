using System;

namespace BasicSyntaxMoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int theLarge = Math.Max(Math.Max(num1, num2), num3);

            if(num1 == theLarge)
            {
                Console.WriteLine(num1);
                Console.WriteLine(Math.Max(num2,num3));
                Console.WriteLine(Math.Min(num2,num3));

            }
            else if (num2 == theLarge)
            {
                Console.WriteLine(num2);
                Console.WriteLine(Math.Max(num1, num3));
                Console.WriteLine(Math.Min(num1, num3));

            }
            else if(num3 == theLarge)
            {
                Console.WriteLine(num3);
                Console.WriteLine(Math.Max(num1, num2));
                Console.WriteLine(Math.Min(num1, num2));

            }
        }
    }
}
