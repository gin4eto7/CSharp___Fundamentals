using System;

namespace _07ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            String name1 = Console.ReadLine();
            String name2 = Console.ReadLine();
            String delimeter = Console.ReadLine();

            Console.WriteLine($"{name1}{delimeter}{name2}");
        }
    }
}
