using System.Xml.Schema;

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestNumber(num1,num2,num3));

        }
        static int SmallestNumber(int n1,int n2, int n3)
        {
            if (n1 > n2 && n2 < n3) return n2;
           else if (n1 < n2 && n1 < n3) return n1;
            else return n3;
            
        }
    }
}