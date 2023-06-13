using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] time = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            float leftTime = 0;
            float rightTime = 0;
            for (int i = 0; i < time.Length/2; i++)
            {
                if (time[i] == 0)
                {
                    leftTime = leftTime * 0.8f;
                    continue;
                }
                leftTime += time[i];
            }
            for (int i =time.Length-1 ; i >= time.Length / 2+1; i--)
            {
                if (time[i] == 0)
                {
                    rightTime = rightTime * 0.8f;
                    continue;
                }
                rightTime += time[i];
            }
            if (leftTime > rightTime)
                Console.WriteLine($"The winner is right with total time: {rightTime}");
            else
                Console.WriteLine($"The winner is left with total time: {leftTime}");
        }
    }
}
