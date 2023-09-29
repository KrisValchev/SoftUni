namespace _04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\n",Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray()
                .Select(x=>$"{x+x*0.2:f2}")));
        }
    }
}