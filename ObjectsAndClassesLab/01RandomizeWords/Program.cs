using System;
using System.Linq;

namespace _01RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            Random rand = new Random();

            Randomize.PrintRandom(input, rand);
            
        }
    }

    public class Randomize
    {
        public static void PrintRandom(string[] input, Random rand)
        {
            for (int i1 = 0; i1 < input.Length; i1++)
            {
                int i2 = rand.Next(input.Length);

                string temp = input[i1];
                input[i1] = input[i2];
                input[i2] = temp;

            }

            Console.WriteLine(String.Join(Environment.NewLine, input));
        }
    }

    
}
