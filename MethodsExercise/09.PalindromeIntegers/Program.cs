using System;
using System.Linq;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            while (num != "END")
            {
                Console.WriteLine(IfTheNumIsPalindrome(num).ToString().ToLower());
                num = Console.ReadLine();
            }
        }
        static bool IfTheNumIsPalindrome (string num)
        {
            var revursed = num.Reverse().ToArray();
            for (int i = 0; i < num.Length; i++)
            {
                if (!(num[i] == revursed[i]))
                {
                    return false;
                }

            }
            return true;
        }
    }
}
