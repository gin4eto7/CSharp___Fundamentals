using System;
using System.Numerics;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine();
            int smallNum = int.Parse(Console.ReadLine());
            StringBuilder bilder = new StringBuilder();
            int result = 0;
            int remainder = 0;
            if(smallNum == 0)
            {
                Console.WriteLine("0");
                return;
            }

            while(bigNum == "0")
            {
                bigNum = bigNum.Substring(1);
            }
            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                
                result = (int.Parse(bigNum[i].ToString()) * smallNum + remainder);
                remainder = 0;

                if (result > 9)
                {
                   
                    remainder = result / 10;
                    result = result % 10;
                }

                bilder.Append(result);
                
            }
            if (remainder != 0)
            {
                bilder.Append(remainder);
            }
            StringBuilder final = new StringBuilder();

            for (int i = bilder.Length - 1; i >= 0; i--)
            {
                final.Append(bilder[i]);
            }

            Console.WriteLine(final);
        }
    }
}
