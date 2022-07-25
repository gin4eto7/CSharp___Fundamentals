using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            double bigerKeg = Int64.MinValue;
            string theKeg = "";

            for (int i = 0; i < n; i++)
            {
                double volumeUsing = 0;
                
                string modelKeg = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                float height = float.Parse(Console.ReadLine());

                volumeUsing = (double)Math.PI * radius * radius * height;

                if (volumeUsing >= bigerKeg)
                {
                    bigerKeg = volumeUsing;
                    theKeg = modelKeg;
                }
            }
            Console.WriteLine(theKeg);
        }
    }
}
