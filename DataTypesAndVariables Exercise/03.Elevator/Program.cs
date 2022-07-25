using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int course = (int)Math.Ceiling((double)numOfPeople / capacity);

            Console.WriteLine(course);
        }
    }
}
