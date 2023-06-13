using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "3:1")
                {
                    Console.WriteLine(string.Join(" ", strings));
                    break;
                }
                if (input[0] == "merge")
                {
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);
                    if (startIndex < 0 || startIndex>strings.Count-1)
                        startIndex = 0;
                    if (endIndex > strings.Count - 1)
                        endIndex = strings.Count - 1;
                    Merge(strings, startIndex, endIndex);
                }
                if (input[0] == "divide")
                {
                    int index = int.Parse(input[1]);
                    int partitions = int.Parse(input[2]);
                    Divide(strings, index, partitions);
                }
            }
        }
        static List<string> Merge(List<string> list, int startIndex, int endIndex)
        {
            string merge = "";
            for (int i = startIndex; i <= endIndex; i++)
            {
                merge += list[startIndex];
                list.RemoveAt(startIndex);
            }
            list.Insert(startIndex, merge);
            return list;
        }
        static List<string> Divide(List<string> list, int index, int partitions)
        {
                int indexOfLength = 0;
            if (list[index].Length % partitions == 0)
            {
                for (int i = 0; i < partitions; i++)
                {
                    string part = "";
                    for (int j =0; j < list[index+i].Length / partitions; j++)
                    {
                        part += list[index+i][indexOfLength].ToString();
                        indexOfLength++;
                    }
                        list.Insert(index+i, part);
                }
                list.RemoveAt(index + partitions);
            }
            else
            {
                for (int i = 0; i < partitions-1; i++)
                {
                    string part = "";
                    for (int j = 0; j < list[index+i].Length / partitions; j++)
                    {

                        part += list[index+i][indexOfLength].ToString();
                        indexOfLength++;
                    }
                    list.Insert(index + i, part);

                }
                string lastPart = "";
                for (int i = indexOfLength; i < list[index+partitions-1].Length; i++)
                {
                    lastPart+= list[index + partitions-1][i].ToString();
                }
                list.RemoveAt(index + partitions-1);
                list.Insert(index + partitions-1, lastPart);
            }
            return list;
        }
    }
}
