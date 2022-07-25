using System;

namespace Arrays_MoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int countWords = int.Parse(Console.ReadLine());
           
            int[] finalNums = new int[countWords];

            for (int i = 0; i < countWords; i++)
            {
                int vowel = 0;
                int consonant = 0;
                string names = Console.ReadLine();
                for (int j = 0; j < names.Length; j++)
                {
                    char[] strToChar = names.ToCharArray();

                    

                    if (strToChar[j] == 'a' || strToChar[j] == 'e' || strToChar[j] == 'o' || strToChar[j] == 'u' || strToChar[j] == 'i')
                    {
                        vowel += strToChar[j];
                    }
                    else
                    {
                        consonant += strToChar[j];
                    }
                }
                vowel *= names.Length;
                consonant /= names.Length;

                int total = (vowel + consonant) - 1;

                finalNums[i] = total;
            }
            //int minNum = int.MaxValue;

            Array.Sort(finalNums);

            foreach (var item in finalNums)
            {
                Console.WriteLine(item);
            }

        }
    }
}
