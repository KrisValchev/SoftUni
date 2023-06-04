namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                PrintRow(row);
            }
            for (int row = n-1; row >= 1; row--)
            {
                PrintRow(row);
            }
        }
        static void PrintRow(int row)
        {
            string line = "";
            for (int number = 1; number <= row; number++)
            {
                line += number + " ";
            }
            Console.WriteLine(line.Trim());
        }
    }
}