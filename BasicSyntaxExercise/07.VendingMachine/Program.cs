using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //. Until you receive "Start" you will be given different coins 
            //. You have to sum them
            //works with 0.1, 0.2, 0.5, 1, and 2 coins
            //to insert some other coins you have to display "Cannot accept {money}" and not add
            //until you receive "End" you will be given products 
            //"Nuts", "Water", "Crisps", "Soda", "Coke"
            //2.0, 0.7, 1.5, 0.8, 1.0 
            //If the person tries to purchase a not existing product print "Invalid product"
            //they don’t have the money for. In that case print "Sorry, not enough money". 
            //successfully print "Purchased {product name}". 
            //After the "End" format "Change: {money left}".
            string coinsStart = "";
            double sumCoins = 0;
            while (coinsStart != "Start")
            {
                coinsStart = Console.ReadLine();
                if (coinsStart == "Start")
                {
                    break;
                }
                else
                {

                    double coins = double.Parse(coinsStart);
                    if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                    {
                        sumCoins += coins;
                    }
                    else
                    {
                        Console.WriteLine($"Cannot accept {coins}");
                    }

                }
            }
            string product = "";
            double price = 0;
            double sumPrice = 0;
            while (product != "End")
            {
            product = Console.ReadLine();
                
                if (product == "End")
                {
                    break;
                }
                else
                {
                    switch (product)
                    {
                        case "Nuts":
                            price = 2.0;
                            break;
                        case "Water":
                            price = 0.7;
                            break;
                        case "Crisps":
                            price = 1.5;
                            break;
                        case "Soda":
                            price = 0.8;
                            break;
                        case "Coke":
                            price = 1.0;
                            break;
                        default:
                            Console.WriteLine("Invalid product");
                            continue;

                    }

                    //sumPrice += price;
                    
                    //sumPrice -= price;
                    //product = Console.ReadLine();
                    if (sumCoins >= price)
                    {
                        sumCoins = sumCoins - price;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        
                        Console.WriteLine("Sorry, not enough money");
                       
                    }
                }
            }
            Console.WriteLine($"Change: {sumCoins:f2}");


        }
    }
}
