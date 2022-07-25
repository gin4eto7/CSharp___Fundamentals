using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> comand = Console.ReadLine().Split().ToList();
            while (comand[0] != "End")
            {

                switch (comand[0])
                {

                    case "Add":
                        int num = int.Parse(comand[1]);
                        numbers.Add(num);
                        break;
                    case "Insert":
                        int index = int.Parse(comand[2]);
                        if(index > numbers.Count - 1 || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        int numb = int.Parse(comand[1]);
                        numbers.Insert(index, numb);
                        break;
                    case "Remove":
                        int delNumIndex = int.Parse(comand[1]);
                        if (delNumIndex > numbers.Count - 1 || delNumIndex < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        numbers.RemoveAt(delNumIndex);
                        break;
                    case "Shift":
                        
                        int count = int.Parse(comand[2]);
                        if (comand[1] == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Add(numbers[0]);
                                numbers.RemoveAt(0);

                            }
                        }
                        else if(comand[1] == "right")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Insert(0,numbers[numbers.Count - 1]);
                                numbers.RemoveAt(numbers.Count - 1);

                            }
                        }
                        break;
                }
                comand = Console.ReadLine().Split().ToList();

            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
