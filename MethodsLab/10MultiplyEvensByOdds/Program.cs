using System;

namespace _10MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numAbs = Math.Abs(num);
            

            Console.WriteLine(GetMultipleOfEvenAndOdds(numAbs));
        }

        static int GetMultipleOfEvenAndOdds(int numAbs)
        {
            int multiple = GetSumOfOddDigits(numAbs) * GetSumOfEvenDigits(numAbs);
            return multiple;
        }

        static int GetSumOfEvenDigits(int numAbs)
        {
            string numToString = numAbs.ToString();
            int evenSum = 0;
            for (int i = 0; i < numToString.Length; i++)
            {
                int currNum = int.Parse(numToString[i].ToString());
                if(currNum % 2 != 0)
                {
                    evenSum += currNum;
                }
            }
             
            return evenSum;
        }

        static int GetSumOfOddDigits(int numAbs)
        {
            string numToString = numAbs.ToString();
            int oddSum = 0;
            for (int i = 0; i < numToString.Length; i++)
            {
                int currNum = int.Parse(numToString[i].ToString());
                if (currNum % 2 == 0)
                {
                    oddSum += currNum;
                }
            }

            return oddSum;
        }
    }
}
