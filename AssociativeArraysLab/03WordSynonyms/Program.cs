using System;
using System.Collections.Generic;

namespace _03WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                string sinonym = Console.ReadLine();

                if (!dic.ContainsKey(word))
                {
                    dic.Add(word, new List<string>());
                    dic[word].Add(sinonym);
                }
                else
                {
                    dic[word].Add(sinonym);
                }
            }

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} - {String.Join(", ", item.Value)}");
            }
        }
    }
}
