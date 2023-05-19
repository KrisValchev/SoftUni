namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            string model = string.Empty;
            double volume = 0;
            
                for (int j = 0; j < numberOfLines; j++)
                {
                    string currentModel = Console.ReadLine();
                    double r = double.Parse(Console.ReadLine());
                    int height = int.Parse(Console.ReadLine());
                    if(Math.PI*r*r*height>=volume)
                    {
                        model = currentModel;
                        volume = Math.PI * r * r * height;
                    }
                }
            Console.WriteLine(model);
        }
    }
}