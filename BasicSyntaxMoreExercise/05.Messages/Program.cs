using System;

namespace _05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string oneNum = "";
            string letter = "";
            int whileNum = 0;
            int j = 0;

            for (int i = 0; i < count; i++)
            {
                string nums = Console.ReadLine();
                for (j = 0; j < nums.Length; j++)
                {
                    oneNum += nums[j];
                    whileNum++;


                }

            }
            if (whileNum == 0)
            {

            }
            else if(whileNum == 1)
            {

            }
            else if(whileNum == 2)
            {
                letter = "c";
            }

        }
    }
}
