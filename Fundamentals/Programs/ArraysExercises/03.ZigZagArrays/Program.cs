namespace _03.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfLines =int.Parse( Console.ReadLine());
            int[] firstArray=new int[numOfLines];
            int[] secondArray=new int[numOfLines];
            for (int i = 0; i < numOfLines; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if(i%2==0)
                {
                    firstArray[i] = numbers[0];
                    secondArray[i] = numbers[1];
                }
                else
                {
                    firstArray[i] = numbers[1];
                    secondArray[i] = numbers[0];
                }
            }
            for (int i = 0; i < firstArray.Length-1; i++)
            {
                Console.Write(firstArray[i]+" ");
            }
            Console.WriteLine(firstArray[firstArray.Length-1]);
            for (int i = 0; i < secondArray.Length - 1; i++)
            {
                Console.Write(secondArray[i] + " ");
            }
            Console.WriteLine(secondArray[secondArray.Length - 1]);
        }
    }
}