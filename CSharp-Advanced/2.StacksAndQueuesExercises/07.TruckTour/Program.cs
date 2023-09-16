using System;
using System.Collections.Generic;
using System.Linq;
namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int petrolPumpsCount = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>(); //int[]=> (int,int)
            for (int i = 0; i < petrolPumpsCount; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();//1 5
                int petrol = input[0];
                int distance = input[1];
                pumps.Enqueue(input);//=> (petrol,distance)

            }
            int bestRoute = 0;
            while (true)
            {
                int totalPetrol = 0;
                foreach (int[] pump in pumps) // => (int,int)
                {
                    totalPetrol += pump[0];
                    int currentDistance = pump[1];
                    if (totalPetrol - currentDistance < 0)
                    {
                        totalPetrol = -1;
                        break;
                    }
                    else
                    {
                        totalPetrol -= currentDistance;
                    }
                }
                if (totalPetrol >= 0)
                {
                    break;
                }
                bestRoute++;
                pumps.Enqueue(pumps.Dequeue());

            }
            Console.WriteLine(bestRoute);
        }
    }
}
