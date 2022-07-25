using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Every second lost game, Pesho trashes his headset.
            //Every third lost game, Pesho trashes his mouse.
            //When Pesho trashes both his mouse and headset, trashes his keyboard.
            //Every second time, when he trashes his keyboard, he also trashes his display.

            double lostGame = double.Parse(Console.ReadLine());
            double headsetPrise = double.Parse(Console.ReadLine());
            double mousePriese = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double headsetCount = 0;
            double mouseCount = 0;
            double keyboardCount = 0;
            double displayCount = 0;

            for (int i = 1; i <= lostGame; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCount++;
                    if(i % 3 == 0)
                    {
                        keyboardCount++;
                        
                    }
                }

                if(i % 3 == 0)
                {
                    mouseCount++;
                    
                }
            }
            for (int j = 1; j <= keyboardCount; j++)
            {
                if (j % 2 == 0)
                {
                    displayCount++;
                }
            }
            double totalTrash = headsetCount * headsetPrise + mouseCount * mousePriese + keyboardCount * keyboardPrice + displayCount * displayPrice;

            Console.WriteLine($"Rage expenses: {totalTrash:f2} lv.");
        }
    }
}
