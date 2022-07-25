using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(FindsAndSumVowels(input));
        }

        static string FindsAndSumVowels (string input)
        {
            int countVowels = 0;
            for (int i = 0; i < input.Length; i++)
            {
                
                if (input[i] == 'a' || input[i] == 'o' || input[i] == 'u' || input[i] == 'e' || input[i] == 'i' || input[i] == 'A' || input[i] == 'O' || input[i] == 'U' || input[i] == 'E' || input[i] == 'I')
                {
                    countVowels++;
                }
            }
            return countVowels.ToString();
        }
    }
}
