namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray=Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < numbersArray.Length; i++)
            {
            int leftSum = 0;
            int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += numbersArray[j];
                }
                for (int j = numbersArray.Length-1; j > i; j--)
                {
                    rightSum+= numbersArray[j];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}