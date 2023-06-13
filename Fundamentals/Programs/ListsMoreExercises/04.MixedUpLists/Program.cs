using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _04.MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondList = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            List<int> mixedList = new List<int>();
            int firstBorder = 0;
            int secondBorder = 0;
            mixedList = MixLists(ref firstList, ref secondList);
            if (firstList.Count != 0)
            {
                if (firstList[0] < firstList[1])
                {
                    firstBorder = firstList[0];
                    secondBorder = firstList[1];
                }
                else
                {
                    firstBorder = firstList[1];
                    secondBorder = firstList[0];
                }
            }
            else if(secondList.Count!=0)
            {
                if (secondList[0] < secondList[1])
                {
                    firstBorder = secondList[0];
                    secondBorder = secondList[1];
                }
                else
                {
                    firstBorder =   secondList[1];
                    secondBorder = secondList[0];
                }
            }
            mixedList = TakeInBorders(mixedList, firstBorder, secondBorder);
            mixedList.Sort();
            Console.WriteLine(string.Join(" ",mixedList));
        }
        static List<int> MixLists(ref List<int> firstList,ref List<int> secondList)
        {

            List<int> mixedList = new List<int>();
            while (firstList.Count != 0 && secondList.Count != 0)
            {
                mixedList.Add(firstList[0]);
                mixedList.Add(secondList[secondList.Count-1]);
                firstList.RemoveAt(0);
                secondList.RemoveAt(secondList.Count-1);

            }
            
            return mixedList;
        }
        static List<int> TakeInBorders(List<int> list,int firstBorder, int secondBorder)
        {
            List<int> mix = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i]>firstBorder && list[i]<secondBorder)
                {
                    mix.Add(list[i]);
                }
            }
            return mix;
        }
    }
}
