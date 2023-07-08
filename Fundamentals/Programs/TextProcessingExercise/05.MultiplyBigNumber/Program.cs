using System;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int singleDigitNumber = int.Parse(Console.ReadLine());
            string result = "";
            int keepInMind = 0;
            if (singleDigitNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = number.Length - 1; i >= 0; i--)
            {
                    result = (((int.Parse(number[i].ToString()) * singleDigitNumber + keepInMind) % 10)).ToString()+result;
                    keepInMind = (int.Parse(number[i].ToString()) * singleDigitNumber+keepInMind) / 10;
               
            }
            if(keepInMind!=0)
            {
                result = keepInMind + result;
            }
            Console.WriteLine(result);
        }
    }
}
