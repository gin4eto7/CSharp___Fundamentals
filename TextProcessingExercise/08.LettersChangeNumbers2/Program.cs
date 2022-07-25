using System;

namespace _08.LettersChangeNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);


            double totalResult = 0;

            for (int i = 0; i < input.Length; i++)
            {
                double resultFirst = 0;
                double resultSecond = 0;
                string currWord = input[i];

                char firstLetter = currWord[0];
                char lastLetter = currWord[currWord.Length - 1];
                double number = double.Parse(currWord.Substring(1, currWord.Length - 2));

                int firstLetterPosicion = char.Parse(firstLetter.ToString().ToUpper()) - 64;
                int lastLetterPsicion = char.Parse(lastLetter.ToString().ToUpper()) - 64;


                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    number /= firstLetterPosicion;
                }
                else
                {
                    number *= firstLetterPosicion;
                }

                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    number -= lastLetterPsicion;
                }
                else
                {
                    number += lastLetterPsicion ;
                }

                totalResult += number;
            }
            Console.WriteLine($"{totalResult:f2}");
        }
    }
}
