using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> stackOfClothes = new Stack<int>(clothes);
            int racks = 1;
            int sumOfClothes = 0;
            while (stackOfClothes.Count>0)
            {
                if(sumOfClothes+stackOfClothes.Peek()<rackCapacity)
                {
                    sumOfClothes += stackOfClothes.Pop();
                }
               else if(sumOfClothes+stackOfClothes.Peek()==rackCapacity)
                {
                    sumOfClothes=0;
                    stackOfClothes.Pop();
                    if (stackOfClothes.Count != 0) racks++;
                }
                else
                {
                    sumOfClothes = 0;
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
