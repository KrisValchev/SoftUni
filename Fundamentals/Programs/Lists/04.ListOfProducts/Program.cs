namespace _04.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                list.Add(product);
            }
            list.Sort();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + "." + list[i-1]);
            }
        }
    }
}