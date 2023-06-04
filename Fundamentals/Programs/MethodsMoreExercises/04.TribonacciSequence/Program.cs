using System.Runtime.CompilerServices;
using System.Security;

namespace _04.TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string line = "";
            for (int i = 1; i <= num; i++)
            {
                line += Tribonacci(i)+" ";
            }
            Console.WriteLine(line.Trim());
        }
        static int Tribonacci(int num)
        {
            if (num == 1 || num == 2)
                return 1;
            if(num==3) return 2;
            //return Tribonacci(num - 2) + Tribonacci(num - 1) + Tribonacci(num - 3);
            int previous1 = 1;
            int previous2 = 1;
            int previous3 =2 ;
            int currentNumber = 0;
            for (int i = 4; i <= num; i++)
            {
                currentNumber = previous1 + previous2 + previous3;
                previous1 = previous2;
                previous2 = previous3;
                previous3 = currentNumber;
            }
            return currentNumber;
        }
    }
}