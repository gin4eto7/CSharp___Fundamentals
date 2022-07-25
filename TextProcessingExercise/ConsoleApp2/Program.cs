using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string validUser = String.Empty;
            List<string> userList = new List<string>();

            for (int i = 0; i < userNames.Length; i++)
            {
                string curr = userNames[i];
                List<string> valid = new List<string>();

                if (curr.Length >= 3 && curr.Length <= 16)
                {
                    bool isValid = true;
                    for (int j = 0; j < curr.Length; j++)
                    {
                        
                        if (!(Char.IsLetterOrDigit(curr[j]) || curr[j] == '-' || curr[j] == '_'))
                        {
                            isValid = false;
                        }


                    }
                    if(isValid)
                    {
                        userList.Add(curr);
                    }

                }
                
            }
            foreach (var user in userList)
            {
                Console.WriteLine(user);
            }
            
        }
    }
}
