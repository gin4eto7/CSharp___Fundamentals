using System;

namespace _11RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"Length: {lenght}");
            
            Console.WriteLine($"Width: {width}");
            
            Console.WriteLine($"Heigth: {height}");
            
            height = (lenght * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {height:f2}");

        }
    }
}
