using System.Data;
using System.Runtime.InteropServices;
using System.Security;

namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfSample = int.Parse(Console.ReadLine());
            int[] bestSample = new int[lenghtOfSample];

            int bestSequenceLength = 0;
            int bestSequenceIndex = 0;
            int lefterIndex = lenghtOfSample;
            int bestSumOfOnes = 0;

            int[] sample;
            int sequenceLength = 0;
            int startingIndex = 0;
            int sequenceIndex = 0;
            while (true)
            {
                bool statistics = false;
                int sumOfOnes = 0;
                sequenceIndex++;
                int countOfOnes = 1;
                string input = Console.ReadLine();
                if (input == "Clone them!") break;
                sample = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int i = 0; i < sample.Length; i++)
                {
                    sumOfOnes += sample[i];
                }

                for (int i = 0; i < sample.Length - 1; i++)
                {
                    if (sample[i] == sample[i + 1] && sample[i] != 0)
                    {
                        countOfOnes++;
                        if (countOfOnes == 2)
                        {
                            startingIndex = i;
                        }
                    }
                    else
                    {
                        countOfOnes = 1;
                    }
                    if (sequenceLength < countOfOnes)
                    {
                        sequenceLength = countOfOnes;
                    }
                }
                if (sequenceLength > bestSequenceLength)
                {
                    statistics = true;
                }
                else if (sequenceLength == bestSequenceLength)
                {
                    if (startingIndex < lefterIndex)
                    {
                        statistics = true;
                    }
                    else
                    {
                        if (sumOfOnes > bestSumOfOnes)
                        {
                            statistics = true;
                        }
                    }
                }
                if (statistics == true)
                {
                    bestSequenceLength = sequenceLength;
                    bestSequenceIndex = sequenceIndex;
                    lefterIndex = startingIndex;
                    bestSumOfOnes = sumOfOnes;
                    bestSample = sample;
                }
            }
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSumOfOnes}.");
            Console.WriteLine($"{string.Join(" ", bestSample)}");
        }
    }
}