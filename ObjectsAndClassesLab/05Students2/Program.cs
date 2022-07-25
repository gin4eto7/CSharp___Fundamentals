using System;
using System.Collections.Generic;
using System.Linq;

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

               

                if(IsStudentExist(students, firstName, lastName))
                {
                    GetStudent(students, firstName, lastName, age);
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown,
                    };

                    students.Add(student);
                }

                


                input = Console.ReadLine();
            }

            string nameTown = Console.ReadLine();
            List<Student> filter = students.Where(s => s.HomeTown == nameTown).ToList();
            foreach (var student in filter)
            {
                
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                

            }
        }


        static bool IsStudentExist (List<Student> students, string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        static void GetStudent(List<Student> students, string firstName, string lastName, int age)
        {


            foreach (var student in students)
            {
                if(student.FirstName == firstName && student.LastName == lastName)
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = student.HomeTown;
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
