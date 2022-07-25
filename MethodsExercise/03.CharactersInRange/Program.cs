using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char final = char.Parse(Console.ReadLine());
            PrintAllCharacters(start, final);
        }

        static void PrintAllCharacters(char start, char final)
        {
            int minChar = Math.Min(start, final);
            int maxChar = Math.Max(start, final);
            for (int i = minChar + 1; i < maxChar; i++)
            {

                Console.Write((char)i + " ");

            }
        }
    }
}
