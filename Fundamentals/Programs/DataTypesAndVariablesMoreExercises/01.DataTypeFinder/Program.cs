namespace _01.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                var input = Console.ReadLine();
                if (input == "END") break;
                int integer;
                double floatingPoing;
                char characters;
                string strings;
                bool boolean;
                if(int.TryParse(input,out integer))
                    Console.WriteLine($"{input} is integer type");
                else if (double.TryParse(input, out floatingPoing))
                    Console.WriteLine($"{input} is floating point type");
                else if (char.TryParse(input, out characters))
                    Console.WriteLine($"{input} is character type");
                else if (bool.TryParse(input, out boolean))
                    Console.WriteLine($"{input} is boolean type");
                else Console.WriteLine($"{input} is string type");

            }
        }
    }
}