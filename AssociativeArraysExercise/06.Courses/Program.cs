using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> registeredStudents = new Dictionary<string, List<string>>();

            while (true)
            {

                string[] input = Console.ReadLine().Split(" : ").ToArray();

                if (input[0] == "end")
                {
                    break;
                }

                string course = input[0];
                string name = input[1];

                if (!registeredStudents.ContainsKey(course))
                {
                    registeredStudents.Add(course, new List<string>() { name });

                }
                else
                {
                    registeredStudents[course].Add(name);
                }
            }

            foreach (var course1 in registeredStudents.OrderByDescending(x => x.Value.Count))
            {

                Console.WriteLine($"{course1.Key}: {course1.Value.Count}");

                foreach (var stud in course1.Value.OrderBy(n => n))
                {
                    Console.WriteLine($"-- {stud}");
                }
            }

        }   
    }
}
