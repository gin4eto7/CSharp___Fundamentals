using System;
using System.Collections.Generic;

namespace _04Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (input != "end")
            {
                string[] info = input.Split(" ");

                string firstName = info[0];
                string lastName = info[1];
                int age = int.Parse(info[2]);
                string homeTown = info[3];

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = homeTown;

                students.Add(student);


                input = Console.ReadLine();
            }

            string nameTown = Console.ReadLine();

            foreach (var student in students)
            {
                if(nameTown == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
                
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
}
