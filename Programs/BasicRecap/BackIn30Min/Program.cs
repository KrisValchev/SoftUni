namespace BackIn30Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes= int.Parse(Console.ReadLine());
            minutes += 30;
            if(minutes>=60)
            {
                minutes -= 60;
                hours += 1;
                if (hours > 23)
                    hours = 0;
            }
            Console.WriteLine( $"{hours}:{minutes:d2}");
        }
    }
}