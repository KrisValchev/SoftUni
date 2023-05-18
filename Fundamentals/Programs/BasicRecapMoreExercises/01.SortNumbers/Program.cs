namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int[] order = { num1, num2, num3 };
            int max = 0;
            for (int i = 0; i < order.Length; i++)
            {
                for (int j = 0; j < order.Length; j++)
                {
                    if (order[i] > order[j])
                    {
                        max = order[j];
                        order[j] = order[i];
                        order[i] = max;
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(order[i]);

            }

        }
    }
}