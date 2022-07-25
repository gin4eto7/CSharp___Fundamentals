using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] commands = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string currComand = commands[0];
                
                if(currComand == "Move")
                {
                    int length = int.Parse(commands[1]);

                    string sub = name.Substring(0, length);
                    name = name.Remove(0, length);
                    name = name.Insert(name.Length, sub);
                }
                else if(currComand == "Insert")
                {
                    int index = int.Parse(commands[1]);
                    string value = commands[2];

                    name = name.Insert(index, value);
                }
                else if(currComand == "ChangeAll")
                {
                    string substring = commands[1];
                    string replacement = commands[2];
                    name = name.Replace(substring, replacement);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {name}");
        }
    }
}
