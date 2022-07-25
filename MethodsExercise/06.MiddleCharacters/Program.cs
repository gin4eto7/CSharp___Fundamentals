using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(DivideString(input));
        }

        static string DivideString(string input)
        {
            string result = "";

            if(input.Length % 2 == 0)
            {
                result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
                
            }
            else
            {
                result = input[input.Length / 2].ToString();
            }
            return result;
        }

    }
}
