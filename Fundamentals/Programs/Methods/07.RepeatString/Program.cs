using System.Reflection.Metadata.Ecma335;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatingTimes = int.Parse(Console.ReadLine());
            Console.WriteLine(Repeat(input,repeatingTimes));
        }
        static string Repeat(string word,int repeatingTimes)
        {
            string result="";
            for (int i = 0; i < repeatingTimes; i++)
            {
               result+= word;
            }
            return result;
        }
    }
}