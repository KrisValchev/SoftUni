namespace _05.AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command;
            while ((command =Console.ReadLine())!="end")
            {
                if(command=="add")
                {
                    numbers= numbers.Select(x => x + 1).ToArray();
                }
                else if(command=="multiply")
                {
                   numbers= numbers.Select(x => x * 2).ToArray();
                }
                else if(command=="subtract")
                {
                    numbers = numbers.Select(x => x - 1).ToArray();
                }
                else
                {
                    Console.WriteLine(string.Join(" ",numbers));
                }
            }
        }
    }
}