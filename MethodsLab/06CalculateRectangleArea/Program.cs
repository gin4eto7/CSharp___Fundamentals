using System;

namespace _06CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateTriangle(width, height));
        }

        static int CalculateTriangle(int width, int height)
        {
            int area = width * height;
            return area;
        }
    }
}
