using System;
using System.Text;
namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] twoStrings = Console.ReadLine().Split();
            int index = 0;
            int result = 0;
            if (twoStrings[0].Length >= twoStrings[1].Length)
            {
                index = twoStrings[1].Length - 1;
                result=MultiplyCodes(twoStrings[0], twoStrings[1], index)+AddRemainingLettersCodes(index,twoStrings[0]);
            }
            else
            {
                index = twoStrings[0].Length - 1;
                
                result=MultiplyCodes(twoStrings[0], twoStrings[1], index)+AddRemainingLettersCodes(index,twoStrings[1]) ;
            }
            Console.WriteLine(result);
        }
        static int MultiplyCodes(string str1, string str2, int index)
        {
            int result = 0;
            for (int i = 0; i <= index; i++)
            {
                result += str1[i] * str2[i];
            }
            return result;
        }
        static int AddRemainingLettersCodes(int indexToStartOf,string str2)
        {
            int result = 0;
            for (int i = indexToStartOf+1; i < str2.Length; i++)
            {
                result += str2[i];
            }
            return result;
        }
    }

}
