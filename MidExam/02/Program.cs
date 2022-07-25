using System;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] comand = Console.ReadLine().Split().ToArray();
            
            while (comand[0] != "end")
            {
                
                switch (comand[0])
                {
                    case "swap":
                        int indexSwap1 = int.Parse(comand[1]);
                        int indexSwap2 = int.Parse(comand[2]);
                        var temp = array[indexSwap1];
                        array[indexSwap1] = array[indexSwap2];
                        array[indexSwap2] = temp;
                        break;
                    case "multiply":
                        int indexMulti1 = int.Parse(comand[1]);
                        int indexMulti2 = int.Parse(comand[2]);
                        array[indexMulti1] = array[indexMulti1] * array[indexMulti2];
                        break;

                    case "decrease":
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] -= 1;
                        }
                        break;
                }
                comand = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(String.Join(", ", array));
        }
    }
}
