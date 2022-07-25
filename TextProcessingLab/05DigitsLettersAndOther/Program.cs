using System;

namespace _05DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string digits = String.Empty;
            string letters = String.Empty;
            string other = String.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char simbol = input[i];
                if (Char.IsDigit(input[i]))
                {
                    digits += simbol;
                }
                else if (Char.IsLetter(simbol))
                {
                    letters += simbol;
                }
                else
                {
                    other += simbol;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
