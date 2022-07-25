using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            string numWord = "";
            numWord += num;
            int sumI = 0;
            int sum = 0;
            for (int i = 0; i < numWord.Length; i++)
            {
                int curr = 0;
                curr = temp % 10;
                temp = (temp - curr) / 10;
                int fact = 1;
                for (int j = 1; j <= curr; j++)
                {
                    fact *= j;
                }
                sum += fact;
            }
            if (num == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
