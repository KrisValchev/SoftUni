namespace ListyIteratorType
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(" ").Skip(1).ToList();//skips the command "Create"
            ListyIterator<string> listyIterator = new ListyIterator<string>(items);
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            listyIterator.Print();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    
                }
            }
        }
    }

}