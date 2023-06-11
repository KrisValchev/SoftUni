namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] =="end")
                {
                    Console.WriteLine(string.Join(" ",list));
                    break;
                }
                if (input[0]=="Delete")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == int.Parse(input[1]))
                            list.Remove(list[i]);
                    }
                }
                if (input[0] == "Insert")
                {
                    list.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
            }
        }
    }
}