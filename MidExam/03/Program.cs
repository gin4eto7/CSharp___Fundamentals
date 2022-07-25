using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int hour = 0;

            int totalEmployees = employee1 + employee2 + employee3;
            while (studentsCount > 0)
            {
                hour++;
                if(hour % 4 == 0)
                {
                    continue;
                }

                studentsCount -= totalEmployees;
            }
            Console.WriteLine($"Time needed: {hour}h.");
        }
    }
}
