using System;

namespace ObjectsAndClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Generator ad = new Generator();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(ad.MakeRandom());
            }
        }
    }

    class Generator
    {
        public string[] Phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

        public string[] Events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

        public string[] Authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

        public string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        public string MakeRandom()
        {
            Random rand = new Random();
            string phrases = Phrases[rand.Next(0, Phrases.Length - 1)];
            string events = Events[rand.Next(0, Events.Length - 1)];
            string authors = Authors[rand.Next(0, Events.Length - 1)];
            string cities = Cities[rand.Next(0, Cities.Length - 1)];

            return $"{phrases} {events} { authors} - { cities}";
        }
    }
}
