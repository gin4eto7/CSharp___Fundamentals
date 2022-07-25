using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.Nikulden_smeals
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> likeMeal = new Dictionary<string, List<string>>();
            //List<string> 
            string[] arrInput = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);

            
            int count = 0;
            while (arrInput[0] != "Stop")
            {
                string name = arrInput[1];
                string meal = arrInput[2];
                if (arrInput[0] == "Like")
                {
                    
                    
                    if(!likeMeal.ContainsKey(name))
                    {
                        likeMeal.Add(name, new List<string>() { meal });
                    }
                    else
                    {
                        if(likeMeal[name].Contains(meal))
                        {
                            arrInput = Console.ReadLine()
                                .Split("-", StringSplitOptions.RemoveEmptyEntries);
                            continue;
                        }
                        likeMeal[name].Add(meal);
                    }
                }
                else if(arrInput[0] == "Unlike")
                {
                    if (likeMeal.ContainsKey(name))
                    {


                        if (likeMeal[name].Contains(meal))
                        {
                            count++;
                            likeMeal[name].Remove(meal);

                            Console.WriteLine($"{name} doesn't like the {meal}.");
                        }
                        else 
                        {
                            Console.WriteLine($"{name} doesn't have the {meal} in his/her collection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not at the party.");
                    }
                }


                arrInput = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var person in likeMeal.OrderByDescending(x => x.Value.Count).ThenBy(n => n.Key))
            {

            Console.Write($"{person.Key}: ");
                Console.WriteLine(String.Join(", ", person.Value));
            }
            Console.WriteLine($"Unliked meals: {count}");
        }

    }

}
