using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int length = 1;
        int theLength = 0;

        int start = 0;
        int theStart = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            
            if (numbers[i] == numbers[i + 1])
            {
                length++;
            }
            else
            {
                length = 1;
                start = i + 1;
            }

            if(length > theLength)
            {
                theStart = start;
                theLength = length;
            }
        }

        for (int i = theStart; i < theStart + theLength; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }

}