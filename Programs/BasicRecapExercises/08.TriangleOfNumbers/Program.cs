namespace _08.TriangleOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                string line = "";
                for (int j = 0; j < i; j++)
                {
                    line += i + " ";
                }
                line=line.TrimEnd();
                Console.WriteLine(line);
            }
        }
    }
}