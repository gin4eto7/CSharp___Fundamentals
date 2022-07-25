using System;

namespace _09GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();

            Console.WriteLine(GetMax(type, value1, value2));
        }

        static string GetMax(string type ,string value1, string value2)
        {
            string max = "";
            if(type == "int")
            {
                int num1 = int.Parse(value1);
                int num2 = int.Parse(value2);

                if(num1 > num2)
                {
                    max =  num1.ToString();
                }
                else
                {
                    max = num2.ToString();
                }
            }
            else if(type == "string")
            {

                int maxString = value1.CompareTo(value2);
                if(maxString > 0)
                {
                    max = value1;
                }
                else
                {
                    max = value2;
                }
            }
            else if(type == "char")
            {
                char a = char.Parse(value1);
                char b = char.Parse(value2);


                if(a > b)
                {
                    max = a.ToString();

                }
                else
                {
                    max = b.ToString();
                }
            }

            return max;
        }
    }
}
