using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotacion = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotacion; i++)
            {
                int firstNum = numbers[0];
                int[] temporary = new int[numbers.Length];

                for (int j = 1; j < numbers.Length; j++)
                {
                    temporary[j - 1] = numbers[j];
                }
                temporary[temporary.Length - 1] = firstNum;
                numbers = temporary;
            }
            Console.WriteLine(String.Join(' ', numbers));
        }
    }
}
