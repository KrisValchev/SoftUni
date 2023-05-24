namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = { "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
            int number = int.Parse(Console.ReadLine());
            if(number>0 && number<8)
            Console.WriteLine(dayOfWeek[--number]);
            else Console.WriteLine("Invalid day!");
        }
    }
}