using System;
using System.Linq;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            

            if (input[0].Length < input[1].Length)
            {
                string first = input[0];
                string second = input[1];
                Console.WriteLine(MultiplayFirst(first, second));
            }
            else
            {
                string first = input[1];
                string second = input[0];
                Console.WriteLine(MultiplaySecond(first, second));
            }

            
        }

        static int MultiplayFirst(string first, string second)
        {
            int result = 0;

            for (int i = 0; i < first.Length; i++)
            {

                result = first[i] * second[i];
            }

            for (int j = first.Length; j < second.Length; j++)
            {
                result += second[j];

            }


            return result;
        }
        static int MultiplaySecond(string first, string second)
        {
            int result = 0;
            for (int i = 0; i < first.Length; i++)
            {

                result += first[i] * second[i];
            }

            for (int j = first.Length; j < second.Length; j++)
            {
                result += second[j];

            }
            return result;
        }
    }
}
