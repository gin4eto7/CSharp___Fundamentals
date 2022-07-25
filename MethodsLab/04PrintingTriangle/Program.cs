using System;

namespace _04PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                PrinLine(i);
            }

            for (int i = num - 1; i >= 1; i--)
            {
                PrinLine(i);
            }
        }

        static void PrinLine (int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }


    }
}
