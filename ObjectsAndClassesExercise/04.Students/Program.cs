using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StudentInfo> students = new List<StudentInfo>();

            int studentsCount = int.Parse(Console.ReadLine());


            for (int i = 0; i < studentsCount; i++)
            {
                var info = Console.ReadLine().Split().ToArray();
                StudentInfo studentInfo = new StudentInfo(info[0], info[1], double.Parse(info[2]));

                students.Add(studentInfo);
            }

                Console.WriteLine(String.Join(Environment.NewLine, students.OrderByDescending(x => x.Grade)));

        }
    }

    public class StudentInfo
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public StudentInfo(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}"; 
        }
    }
}
