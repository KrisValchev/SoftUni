namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            NxNMatric(number);
        }
        static void NxNMatric(int number)
        {
            for (int i = 0; i < number; i++)
            {
            string line = "";
                for (int j = 0; j < number; j++)
                {
                    line += number + " ";
                }
                Console.WriteLine(line.Trim());
            }

        }
    }
}