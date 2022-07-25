using System;

namespace MidExamFundamentalsOld2
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int totalPeople = int.Parse(Console.ReadLine());
            int hour = 0;
            int totalAnsers = (employee1 + employee2 + employee3);

            while (totalPeople > 0)
            {

                hour++;

                if (hour % 4 == 0)
                {
                    continue;
                }
                totalPeople -= totalAnsers;



            }
            Console.WriteLine($"Time needed: {hour}h.");

        }
    }
}
