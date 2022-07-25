using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balanse = double.Parse(Console.ReadLine());
            string nameGame = "";
            double price = 0;
            double totalPrice = 0;
            double minusBalanse = balanse;

            while (nameGame != "Game Time")
            {
                nameGame = Console.ReadLine();
                if (nameGame == "Game Time")
                {
                    break;
                }
                else
                {
                    switch (nameGame)
                    {
                        case "OutFall 4":
                            price = 39.99;
                            if(price > balanse)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine($"Bought {nameGame}");
                                balanse -= price;
                                totalPrice += price;
                            }
                            break;

                        case "CS: OG":
                            price = 15.99;
                            if (price > balanse)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine($"Bought {nameGame}");
                                balanse -= price;
                                totalPrice += price;
                            }
                            break;

                        case "Zplinter Zell":
                            price = 19.99;
                            if (price > balanse)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine($"Bought {nameGame}");
                                balanse -= price;
                                totalPrice += price;
                            }
                            break;

                        case "Honored 2":
                            price = 59.99;
                            if (price > balanse)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine($"Bought {nameGame}");
                                balanse -= price;
                                totalPrice += price;
                            }
                            break;

                        case "RoverWatch":
                            price = 29.99;
                            if (price > balanse)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine($"Bought {nameGame}");
                                balanse -= price;
                                totalPrice += price;
                            }
                            break;

                        case "RoverWatch Origins Edition":
                            price = 39.99;
                            if (price > balanse)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine($"Bought {nameGame}");
                                balanse -= price;
                                totalPrice += price;
                            }
                            break;

                        default:
                            Console.WriteLine("Not Found");
                            continue;

                    }
                }
                
                
                if (balanse <= 0)
                {

                    Console.WriteLine("Out of money!");
                    return;
                }
                
            }
            Console.WriteLine($"Total spent: ${totalPrice:f2}. Remaining: ${balanse:f2}");
        }
    }
}
