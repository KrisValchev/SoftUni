namespace _04.FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x=>int.Parse(x)).ToArray();
            int[] firstRow = new int[numbers.Length / 2];
            int[] secondRow = new int[numbers.Length / 2];
            int firstPartOfFirstRowIndex = 0;
            int[] firstPartOfFirstRow = new int[numbers.Length / 4];
            int secondRowIndex = 0;
            for (int i = 0; i < numbers.Length - numbers.Length / 4; i++)
            {
                if (i < numbers.Length / 4)
                {
                    firstPartOfFirstRow[firstPartOfFirstRowIndex] = numbers[i];
                    firstPartOfFirstRowIndex++;
                }
                else
                {
                    secondRow[secondRowIndex] = numbers[i];
                    secondRowIndex++;
                }

            }
            int firstRowIndex = 0;
            for (int i = (numbers.Length / 4)-1; i >= 0; i--)
            {
                firstRow[firstRowIndex] = firstPartOfFirstRow[i];
                firstRowIndex++;
            }
            for (int i = numbers.Length-1; i >=numbers.Length- numbers.Length/4; i--)
            {
                firstRow[firstRowIndex] = numbers[i];
                firstRowIndex++;
            }
            int[] sum= new int[numbers.Length/2];
            for (int i = 0; i < numbers.Length/2; i++)
            {
                sum[i] = firstRow[i] + secondRow[i];
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}