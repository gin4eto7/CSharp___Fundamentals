using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string commands = Console.ReadLine();

            while (commands != "Travel")
            {
                string[] currCommand = commands.Split(":", StringSplitOptions.RemoveEmptyEntries);
                if (commands.Contains("Add"))
                {
                    int index = int.Parse(currCommand[1]);
                    string theString = currCommand[2];
                    if(index > 0 && index < input.Length)
                    {
                        input = input.Insert(index, theString);
                        Console.WriteLine(input);
                    }

                }
                else if(commands.Contains("Remove"))
                {
                    int startIndex = int.Parse(currCommand[1]);
                    int endIndex = int.Parse(currCommand[2]);
                    int length = endIndex - startIndex + 1;
                    if (startIndex > 0 && endIndex < input.Length)
                    {
                        input = input.Remove(startIndex, length);
                        Console.WriteLine(input);
                    }
                }
                else if(commands.Contains("Switch"))
                {
                    string oldString = currCommand[1];
                    string newString = currCommand[2];

                    if(input.Contains(oldString))
                    {
                        input = input.Replace(oldString, newString);
                        Console.WriteLine(input);
                    }

                }

                commands = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
