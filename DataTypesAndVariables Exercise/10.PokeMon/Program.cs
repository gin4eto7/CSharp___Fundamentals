using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            int distansM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int temporaryPokePower = pokePowerN;
            //int tempPersent = temporaryPokePower / 2;
            int countTarget = 0;


            while (pokePowerN >= distansM)
            {
                pokePowerN -= distansM;
                countTarget++;
                if(temporaryPokePower / 2 == pokePowerN)
                {
                    if (exhaustionFactorY > 0)
                    {
                        pokePowerN /= exhaustionFactorY;
                    }
                    
                }
            }
            Console.WriteLine(pokePowerN);
            Console.WriteLine(countTarget);
        }
    }
}
