using System;

namespace _07.NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintsNxNMatrix(num);
        }
        static void PrintsNxNMatrix(int num)
        {
            for (int row = 1; row <= num; row++)
            {
                //Console.Write(num);
                for (int cow = 1; cow <= num; cow++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
