using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int result = int.Parse(Console.ReadLine());

        //int total = 0;
        

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                
                if (numbers[i] + numbers[j] == result)
                {
                    Console.WriteLine($"{numbers[i]} { numbers[j]}");
                    
                }
            }
            
        }

    }

}