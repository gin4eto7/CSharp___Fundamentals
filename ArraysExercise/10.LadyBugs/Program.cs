using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldCount = int.Parse(Console.ReadLine());
            int[] theIndexWithLadyBug = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] field = new int[fieldCount];


            for (int i = 0; i < theIndexWithLadyBug.Length; i++)
            {
                int currIndex = theIndexWithLadyBug[i];
                if (currIndex >= 0 && currIndex < field.Length)
                {
                    field[currIndex] = 1;
                }
                
            }

            //string[] comand = new int[]

            //while (comand != "END")
            //{
            //    string[] comand = Console.ReadLine().Split();
            //
            //
            //    int flyAwai = field[0];
            //
            //}






            //while((comand = Console.ReadLine()) != "END")
            //{
            //    string[] lineComands = comand.Split();
            //    int startLadyBugFly = int.Parse(lineComands[0]);
            //    string rightOrLeft = lineComands[1];
            //    int countFlyCell = int.Parse(lineComands[2]);
            //    
            //    if(startLadyBugFly < 0 || startLadyBugFly > field.Length - 1 || field/[startLadyBugFly] /== 0)
            //    {
            //        continue;
            //    }
            //
            //    field[startLadyBugFly] = 0;
            //    
            //    if(rightOrLeft == "right")
            //    {
            //        int position = startLadyBugFly + countFlyCell;
            //
            //        if(position > field.Length)
            //        {
            //            continue;
            //        }
            //        if(field[position] == 1)
            //        {
            //            while(field[position] == 1)
            //            {
            //                position += countFlyCell;
            //
            //                if (position > field.Length - 1)
            //                {
            //                    break;
            //                }
            //            }
            //        }
            //        field[position] = 1;
            //
            //    }
            //    else if(rightOrLeft == "left")
            //    {
            //        int position = startLadyBugFly - countFlyCell;
            //        if(position < field.Length)
            //        {
            //            continue;
            //        }
            //    }
            //}
        }
    }
}
