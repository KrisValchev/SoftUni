namespace _04.GenericSwapMethodInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
           Box<int> box=new Box<int>();
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                box.Add(int.Parse(input));
            }
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Swap(indexes[0], indexes[1]);
            Console.WriteLine(box);
        }
    }
}