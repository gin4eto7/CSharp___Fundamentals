using System;

namespace _02.EnglishNameOfheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string lastNum= "";
            for (int i = 0; i < num.Length; i++)
            {
                switch (num[i])
                {
                    case '1':
                        lastNum = "one";
                        break;
                    case '2':
                        lastNum = "two";
                        break;
                    case '3':
                        lastNum = "three";
                        break;
                    case '4':
                        lastNum = "four";
                        break;
                    case '5':
                        lastNum = "five";
                        break;
                    case '6':
                        lastNum = "six";
                        break;
                    case '7':
                        lastNum = "seven";
                        break;
                    case '8':
                        lastNum = "eight";
                        break;
                    case '9':
                        lastNum = "nune";
                        break;
                    case '0':
                        lastNum = "zero";
                        break;
                }
            }
            Console.WriteLine(lastNum);
        }
    }
}
