using System;
using System.Linq;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            PasswordValidator(pass);
        }

        static void PasswordValidator(string pass)
        {
            bool valid = false;
            if (pass.Length < 6 || pass.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                valid = true;
            }

            if (!ChecDigitAndLetter(pass))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                valid = true;
            }

            if (ChecIfHaveAtLeastTwoGigits(pass) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                valid = true;
            }

            if (valid == false)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool ChecDigitAndLetter(string pass)
        {
            for (int i = 0; i < pass.Length; i++)
            {
                if (!((pass[i] >= 48 && pass[i] <= 57) || (pass[i] >= 65 && pass[i] <= 90) || (pass[i] >= 97 && pass[i] <= 122)))
                {
                    return false;
                }
            }
            return true;
        }

        static int ChecIfHaveAtLeastTwoGigits(string pass)
        {
            int countDigit = 0;
            for (int i = 0; i < pass.Length; i++)
            {

                if (pass[i] >= 48 && pass[i] <= 57)
                {
                    countDigit++;
                }
            }
            return countDigit;

        }
    }
}
