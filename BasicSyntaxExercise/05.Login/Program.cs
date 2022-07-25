using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            int incorrectPass = 0;
            string pass = "";

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                pass += userName[i];
            }
            string password = Console.ReadLine();
            while (password != pass)
            {

                if (pass != password)
                {
                    incorrectPass++;
                    if (incorrectPass == 4)
                    {
                        Console.WriteLine($"User {userName} blocked! ");
                        return;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }

                password = Console.ReadLine();

            }
            Console.WriteLine($"User {userName} logged in.");
        }
    }
}
