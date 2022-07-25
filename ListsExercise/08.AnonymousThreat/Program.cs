using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            List<string> comand = Console.ReadLine().Split().ToList();

            while(comand[0] != "3:1")
            {
                if(comand[0] == "merge")
                {
                    int startIdex = int.Parse(comand[1]);
                    int finalIndex = int.Parse(comand[2]);
                    
                }
                else if(comand[0] == "divide")
                {


                }
            }

        }

        //private static void Merge(List<string> names, int startIdex, int finalIndex)
        //{
        //    
        //}
    }
}