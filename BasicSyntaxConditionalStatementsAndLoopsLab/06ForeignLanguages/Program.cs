using System;

namespace _06ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();

            switch (city)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
