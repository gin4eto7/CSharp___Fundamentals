using System;

namespace _04ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] input = Console.ReadLine().Split(" ");

            String[] newString = new String[input.Length];
            int index = 0;

            for (int i = input.Length; i > 0; i--)
            {
                newString[index] += input[i - 1];
                index++;
            }

            Console.WriteLine(String.Join(" ", newString));
        }
    }
}
