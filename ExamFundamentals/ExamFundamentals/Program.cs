using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            List<string> comands = Console.ReadLine().Split(":|:").ToList();


            while (comands[0] != "Reveal")
            {
                if (comands[0] == "ChangeAll")
                {
                    string word = comands[1];
                    string change = comands[2];
            
                    String comMess = message.Replace(word, change);
                    message = comMess;
                    Console.WriteLine(message);
                }
            
                else if (comands[0] == "Reverse")
                {
                    if (message.Contains(comands[1]))
                    {
                        comands[1].Reverse();
                        
                    }
                }
                comands = Console.ReadLine().Split(":|:").ToList();
            }
        }
    }
}
