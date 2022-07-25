using System;

namespace _03Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine().Trim().ToLower();
            string input = Console.ReadLine().Trim().ToLower();

            int index = input.IndexOf(key);

            while (index != -1)
            {
                input = input.Remove(index, key.Length);

                index = input.IndexOf(key);
            }
            Console.WriteLine(input);
        }
    }
}
