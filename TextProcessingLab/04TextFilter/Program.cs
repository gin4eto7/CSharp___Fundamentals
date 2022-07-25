using System;

namespace _04TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banned = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            

            foreach (var item in banned)
            {
                if (text.Contains(item))
                {
                    text = text.Replace(item, new string('*', item.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
