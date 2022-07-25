using System;

namespace MIdExamFundamentalsOld
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine(); ;
            int countWin = 0;

            while (comand != "End of battle")
            {

                int distans = int.Parse(comand);

                if(energy >= distans)
                {
                    energy -= distans;
                    countWin++;

                    if (countWin % 3 == 0)
                    {
                        energy += countWin;
                  
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {countWin} won battles and {energy} energy");
                    break;
                }
                comand = Console.ReadLine();
            }
            if(comand == "End of battle")
            {
                Console.WriteLine($"Won battles: {countWin}. Energy left: {energy}");
            }
            
        }
    }
}
