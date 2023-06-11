namespace _04.ListOperations
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
                if (input[0] == "End")
                {
                    Console.WriteLine(string.Join(" ", list));
                    break;
                }
                if (input[0] == "Remove")
                {
                    if(int.Parse(input[1])>=list.Count || int.Parse(input[1])<0)
                    {
                        Console.WriteLine("Invalid index");
                    }   
                    else
                    list.RemoveAt(int.Parse(input[1]));
                }
              else if (input[0] == "Insert")
                {
                    if (int.Parse(input[2]) >= list.Count || int.Parse(input[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    list.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
              else if (input[0] == "Add")
                {
                    list.Add(int.Parse(input[1]));
                }
                else if (input[0] =="Shift" && input[1]=="left")
                {
                    for (int i = 0; i < int.Parse(input[2]); i++)
                    {
                        int firstNumber = 0;
                        firstNumber = list[0];
                        list.Remove(list[0]);
                        list.Add(firstNumber);
                    }
                }
                else
                {
                    for (int i = 0; i < int.Parse(input[2]); i++)
                    {
                        int lastNumber = 0;
                        lastNumber = list[list.Count-1];
                        list.Remove(list[list.Count - 1]);
                        list.Insert(0,lastNumber);
                    }
                }
            }
        }
    }
}