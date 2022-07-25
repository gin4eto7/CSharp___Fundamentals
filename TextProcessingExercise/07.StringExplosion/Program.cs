using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {

            //abv>1>1>2>2asdasd


            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int power = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char curr = input[i];
                if(curr == '>')
                {
                    power += int.Parse(input[i + 1].ToString());
                }
                else if(power > 0 && curr != '>')
                {
                    input = input.Remove(i, 1);
                    power--;
                    i--;
                }

            }
            Console.WriteLine(input);

        }
    }
}
