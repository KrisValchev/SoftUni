namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> list = input.Split('|').ToList();
            List<int> newList= new List<int>();
            for (int i = list.Count-1; i >=0; i--)
            {
                int[] numbers = list[i].Trim().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < numbers.Length; j++)
                {
                    newList.Add(numbers[j]);
                }
            }
            Console.WriteLine(string.Join(" ",newList));
        }
    }
}