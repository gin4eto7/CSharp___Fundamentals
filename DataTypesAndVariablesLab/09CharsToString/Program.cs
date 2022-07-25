using System;

namespace _09CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 3;
            String sumOfChar = "";

            for (int i = 0; i < count; i++)
            {
                char intput = char.Parse(Console.ReadLine());

                sumOfChar += intput;
            }

            Console.WriteLine(sumOfChar);
        }
    }
}
