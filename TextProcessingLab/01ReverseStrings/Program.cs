using System;

namespace _01ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string empti = "";
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    empti += input[i];
                }

                Console.WriteLine($"{input} = {empti}");
                input = Console.ReadLine();
            }
        }
    }
}
