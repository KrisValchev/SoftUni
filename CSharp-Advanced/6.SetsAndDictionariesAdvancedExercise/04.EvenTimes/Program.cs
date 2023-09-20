using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers =int.Parse(Console.ReadLine());
            Dictionary<int, int> numAndRepeating = new Dictionary<int, int>();
            for (int i = 0; i < countOfNumbers; i++)
            {
                int number =int.Parse(Console.ReadLine());
                if(numAndRepeating.ContainsKey(number))
                {
                    numAndRepeating[number]++;
                }
                else
                {
                    numAndRepeating.Add(number, 1);
                }
            }
          
            Console.WriteLine(numAndRepeating.Single(n=>n.Value%2==0).Key);
        }
    }
}
