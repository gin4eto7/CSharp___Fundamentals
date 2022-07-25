using System;
using System.Linq;

namespace _04WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").Where(w => w.Length % 2 == 0).ToArray();

            Console.WriteLine(String.Join(Environment.NewLine, words));
        }

    }
}
