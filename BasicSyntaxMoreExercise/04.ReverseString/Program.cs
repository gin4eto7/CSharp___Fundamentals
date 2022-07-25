using System;

namespace _04.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string reverName = "";

            for (int i = name.Length -1; i >= 0; i--)
            {
                reverName += name[i];
            }
            Console.WriteLine(reverName);
        }
    }
}
