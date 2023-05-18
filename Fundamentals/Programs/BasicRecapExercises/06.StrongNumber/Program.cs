namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sumFactorials = 0;
            for (int i = 0; i < number.Length ; i++)
            {
                int factorialOfNumber = 1;
                for (int j = 0; j < number[i]-48; j++)
                {
                    factorialOfNumber= factorialOfNumber* (j+1);
                }
                sumFactorials += factorialOfNumber;
            }
            if(sumFactorials==int.Parse(number)) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}