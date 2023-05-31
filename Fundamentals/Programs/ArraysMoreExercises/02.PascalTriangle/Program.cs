namespace _02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[] newLine = new int[rows];
            for (int i = 1; i <= rows; i++)
            {
                int[] line = new int[i];
                for (int j = 0; j < i; j++)
                {
                    if (j == 0|| j==i-1)
                    {
                        line[j] = 1;
                        continue;
                    }
                    line[j] = newLine[j] + newLine[j - 1];
                }
                newLine = line;
                Console.WriteLine(string.Join(" ", line));
            }
        }
    }
}