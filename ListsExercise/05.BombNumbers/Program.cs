using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        
        {
            List<int> bombNum = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> code = Console.ReadLine().Split().ToList();

            int specialNum = int.Parse(code[0]);
            int power = int.Parse(code[1]);
            int indexOfSpecialNum = bombNum.IndexOf(specialNum);
            while(indexOfSpecialNum != -1)
            {
                int left = indexOfSpecialNum - power;
                int right = indexOfSpecialNum + power;
                if (left < 0)
                {
                    left = 0;
                }

                if(right > bombNum.Count - 1)
                {
                    right = bombNum.Count - 1;
                }
                bombNum.RemoveRange(left, right - left + 1);

                indexOfSpecialNum = bombNum.IndexOf(specialNum);
            }
            int sum = 0;
            for (int i = 0; i < bombNum.Count; i++)
            {
                sum += bombNum[i];
            }
            Console.WriteLine(sum);
        }
    }
}
