using System.ComponentModel.Design;

namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if(type=="int")
            {
                int input1 = int.Parse(Console.ReadLine());
                int input2 = int.Parse(Console.ReadLine());
                Compare(input1,input2);
            }
           else if(type=="char")
            {
                char input1 = char.Parse(Console.ReadLine());
                char input2 = char.Parse(Console.ReadLine());
                Compare(input1,input2);
            }
            else
            {
                string input1 = Console.ReadLine();
                string input2 =Console.ReadLine();
                Compare(input1,input2);
            }
            
        }
        static void Compare(int a, int b)
        {
            if(a>b)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);
        }
        static void Compare(char a, char b)
        {
            if (a > b)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);
        }
        static void Compare(string a, string b)
        {
            int comparison = a.CompareTo(b);
            if (comparison>0)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);
        }
    }
}