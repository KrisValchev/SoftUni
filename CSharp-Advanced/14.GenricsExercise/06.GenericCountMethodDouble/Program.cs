namespace _06.GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                box.Add(double.Parse(input));
            }
            Console.WriteLine(box.CountOfElementGreaterThan(double.Parse(Console.ReadLine())));
        }
    }
}