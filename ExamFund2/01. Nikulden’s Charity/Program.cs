using System;

namespace _01._Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Finish")
            {
                string[] commands = command.Split();
                string currCommand = commands[0];

                switch (currCommand)
                {
                    case "Replace":
                        string currentChar = commands[1];
                        string newChar = commands[2];
                        input = input.Replace(currentChar, newChar);

                        Console.WriteLine(input);
                        break;

                    case "Cut":
                        int startIndex = int.Parse(commands[1]);
                        int endIndex = int.Parse(commands[2]);
                        int lengthIdex = endIndex - startIndex + 1;

                        if (startIndex > 0 && endIndex < input.Length)
                        {
                            input = input.Remove(startIndex, lengthIdex);

                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indexes!");
                        }
                        break;

                    case "Make":
                        if(commands[1] == "Upper")
                        {
                            input = input.ToUpper();
                        }
                        else if(commands[1] == "Lower")
                        {
                            input = input.ToLower();
                        }
                        Console.WriteLine(input);
                        break;

                    case "Check":
                        string theString = commands[1];
                        if (input.Contains(theString))
                        {
                            Console.WriteLine($"Message contains {theString}");
                        }
                        else
                        {
                            Console.WriteLine($"Message doesn't contain {theString}");
                        }

                        break;
                    case "Sum":
                        int startIndexSum = int.Parse(commands[1]);
                        int endIndexSum = int.Parse(commands[2]);
                        int sum = 0;
                        int lengthSum = endIndexSum - startIndexSum + 1;
                        string subString = String.Empty;
                        if(startIndexSum > 0 && endIndexSum < input.Length)
                        {
                            subString = input.Substring(startIndexSum, lengthSum);

                            for (int i = 0; i < subString.Length; i++)
                            {
                                sum += subString[i];
                            }
                            Console.WriteLine(sum);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indexes!");
                        }
                        break;
                }

                command = Console.ReadLine();
            }
           
        }
    }
}
