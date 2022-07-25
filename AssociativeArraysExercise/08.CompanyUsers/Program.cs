using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();
            
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] info = command
                    .Split(" -> ")
                    .ToArray();


                string companyName = info[0];
                string employeeId = info[1];

                if (!users.ContainsKey(companyName))
                {
                    users.Add(companyName, new List<string>() { employeeId });

                }
                else if (!users[companyName].Contains(employeeId))
                {
                    users[companyName].Add(employeeId);
                   
                }
            }
            foreach (var user in users.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}");
                foreach (var id in user.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
                
            }

        }

    }
}

