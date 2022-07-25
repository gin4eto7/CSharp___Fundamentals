using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> register = new Dictionary<string, string>();
            //Dictionary<string, string> unregister = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split().ToArray();

                string candition = info[0];
                string name = info[1];
                

                if (candition == "register")
                {
                    string number = info[2];
                    if (!register.ContainsKey(name))
                    {

                        register.Add(name, number);

                        Console.WriteLine($"{name} registered {number} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {number}");
                    }
                }
                else if (candition == "unregister")
                {
                    //string condition = info[0];
                    string nameUn = info[1];
                    if (register.ContainsKey(name))
                    {
                        register.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }
            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");

            }
        }
    }
}
