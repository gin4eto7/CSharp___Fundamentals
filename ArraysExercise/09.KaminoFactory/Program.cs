using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string dna = Console.ReadLine();

            int bestLength = 1;
            int bestStartIndex = 0;
            int bestSum = 0;
            int countIndex = 0;
            int bestSequenIndex = 0;

            int[] bestDna = new int[length];

            while (dna != "Clone them!")
            {


                int[] dnaInt = dna
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                countIndex++;

                int bigerLength = 1;
                int lengthNum = 1;
                int startIndex = 0;
                int sum = 0;
                for (int i = 0; i < dnaInt.Length - 1; i++)
                {


                    if (dnaInt[i] == dnaInt[i + 1])
                    {
                        lengthNum++;
                    }
                    else
                    {
                        lengthNum = 1;
                    }

                    if (lengthNum > bigerLength)
                    {
                        bigerLength = lengthNum;
                        startIndex = i;
                    }
                    sum += dnaInt[i];
                }
                sum += dnaInt[length - 1];

                if (bigerLength > bestLength)
                {
                    bestLength = bigerLength;
                    bestStartIndex = startIndex;
                    bestSequenIndex = countIndex;
                    bestSum = sum;
                    bestDna = dnaInt.ToArray();
                }
                else if (bigerLength == bestLength)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestLength = bigerLength;
                        bestStartIndex = startIndex;
                        bestSequenIndex = countIndex;
                        bestSum = sum;
                        bestDna = dnaInt.ToArray();
                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (sum > bestSum)
                        {
                            bestLength = bigerLength;
                            bestStartIndex = startIndex;
                            bestSequenIndex = countIndex;
                            bestSum = sum;
                            bestDna = dnaInt.ToArray();
                        }
                    }
                }
                dna = Console.ReadLine();

            }
            Console.WriteLine($"Best DNA sample {bestSequenIndex} with sum: {bestSum}.");
            Console.WriteLine(string.Join(' ', bestDna));
        }
    }
}
