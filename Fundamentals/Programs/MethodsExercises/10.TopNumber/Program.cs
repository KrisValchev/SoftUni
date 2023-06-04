namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            TopNumbersInRange(end);
        }
        static void TopNumbersInRange(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                string number = i.ToString();
                bool hasOddNumber = false;
                int sum = 0;
                for (int j = 0; j < number.Length; j++)
                {
                    sum += int.Parse(number[j].ToString());
                    if (int.Parse(number[j].ToString()) % 2 != 0)
                    {
                        hasOddNumber = true;
                    }
                }
                if (hasOddNumber)
                {
                    if (sum % 8 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
}