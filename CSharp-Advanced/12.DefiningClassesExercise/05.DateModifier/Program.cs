namespace _05.DateModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstDate = Console.ReadLine().Split();
            string[] secondDate = Console.ReadLine().Split();
            DateTime date1 = new DateTime(int.Parse(firstDate[0]), int.Parse(firstDate[1]), int.Parse(firstDate[2]));
            DateTime date2 = new DateTime(int.Parse(secondDate[0]), int.Parse(secondDate[1]), int.Parse(secondDate[2]));
            Console.WriteLine(Math.Abs(DateModifier.Difference(date1,date2)));
        }
    }
    static class DateModifier
    {
        public static double Difference(DateTime firstDate,DateTime secondDate)
        {
            TimeSpan difference = firstDate.Subtract(secondDate);
            return difference.TotalDays;
        }
    }
}