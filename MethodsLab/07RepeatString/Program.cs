using System;

namespace _07RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepateLine(line, count));
        }

        static string RepateLine (string line, int count)
        {
            string newLine = "";

            for (int i = 0; i < count; i++)
            {
                newLine += line;
            }

            return newLine;
        }
    }
}
