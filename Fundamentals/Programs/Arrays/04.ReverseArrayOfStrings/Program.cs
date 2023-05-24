namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            for (int i =line.Length-1; i >0; i--)
            {
                Console.Write(line[i]+" ");
            }
            Console.WriteLine(line[0]);
        }
    }
}