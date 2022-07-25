using System;
namespace ArraysExercise
{
    class Program
    {
        static void Main()
        {
            int countVagons = int.Parse(Console.ReadLine());
            int[] people = new int[countVagons];

            int sum = 0;

            for (int i = 0; i < countVagons; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                sum += people[i];
            }

            Console.WriteLine(String.Join(' ' , people));
            Console.WriteLine(sum);
        }
    }
}
