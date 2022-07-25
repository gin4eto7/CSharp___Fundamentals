using System;
using System.Linq;

namespace _02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targetsSequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string comand = Console.ReadLine();
            int countGame = 0;

            while (comand != "End")
            {
                int index = int.Parse(comand);
                if(index > targetsSequence.Length-1)
                {
                    comand = Console.ReadLine();
                    continue;
                }
                else
                {
                    int indexTarget = targetsSequence[index]; ;
                    for (int i = 0; i < targetsSequence.Length; i++)
                    {

                        if (targetsSequence[index] == targetsSequence[i])
                        {
                            targetsSequence[index] = -1;
                            continue;
                        }
                        else if (indexTarget < targetsSequence[i])
                        {

                            targetsSequence[i] -= indexTarget;

                            
                        }
                        else if (indexTarget >= targetsSequence[i])
                        {
                            if (targetsSequence[i] == -1)
                            {
                                continue;
                            }
                            else
                            {
                                targetsSequence[i] += indexTarget;
                                
                            }
                            
                        }

                    }
                    countGame++;
                }
                

                comand = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {countGame} ->" + " " + String.Join(" ", targetsSequence));
        }//"Shot targets: {count} -> {target1} {target2}… {targetn}"
    }
}
