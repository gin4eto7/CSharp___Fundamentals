using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            
            for (int i = 0; i < input.Length; i++)
            {
                int sub = 0;
                for (int j = i + 1; j < input.Length; j++)
                {


                    if (input[i] == input[j])
                    {

                        sub++;
                    }
                    else
                    {
                        break;
                    }

                }

                input = input.Remove(i + 1, sub);
            }
            Console.WriteLine(input);
        }
    }
}
