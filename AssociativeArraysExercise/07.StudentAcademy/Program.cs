using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<double>> ollStudentsGrade = new Dictionary<string, List<double>>();
            Dictionary<string, double> totalGradeStudent = new Dictionary<string, double>();

            int countStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < countStudents; i++)
            {
                string nameStudent = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!ollStudentsGrade.ContainsKey(nameStudent))
                {
                    ollStudentsGrade.Add(nameStudent, new List<double>() { grade });
                }
                else
                {
                    ollStudentsGrade[nameStudent].Add(grade);
                }
            }
            
            foreach (var student in ollStudentsGrade.OrderByDescending(x => x.Value.Average()))
            {

                if (student.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.OrderByDescending(x => x).Average():f2}");
                }

            }


        }
    }
}
