namespace _10.LowerOrUppes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char character = char.Parse(Console.ReadLine());
            if (Char.IsUpper(character)) Console.WriteLine("upper-case");
            else Console.WriteLine("lower-case");
        }
    }
}