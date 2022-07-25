using System;
using System.Collections.Generic;

namespace _03Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfSongs = int.Parse(Console.ReadLine());

            List<Songs> listOfSongs = new List<Songs>();

            for (int i = 0; i < numOfSongs; i++)
            {
                string[] info = Console.ReadLine().Split("_");

               

                string typeList = info[0];
                string name = info[1];
                string time = info[2];

                Songs song = new Songs();

                song.TypeList = typeList;
                song.Name = name;
                song.Time = time;

                listOfSongs.Add(song);

            }

            string type = Console.ReadLine();

            if(type == "all")
            {
                foreach (var song in listOfSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in listOfSongs)
                {
                    if(song.TypeList == type)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }

    public class Songs
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}
