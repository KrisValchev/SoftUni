namespace TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int priceTicket = 0;
            if(day=="Weekday")
            {
                if (age >= 0 && age <= 18) priceTicket = 12;
                else if (age >18 && age <= 64) priceTicket = 18;
                else if (age >64 && age <= 122) priceTicket = 12;
            }
           else if (day == "Weekend")
            {
                if (age >= 0 && age <= 18) priceTicket = 15;
                else if (age > 18 && age <= 64) priceTicket = 20;
                else if (age > 64 && age <= 122) priceTicket = 15;
            }
           else if (day == "Holiday")
            {
                if (age >= 0 && age <= 18) priceTicket = 5;
                else if (age > 18 && age <= 64) priceTicket = 12;
                else if (age > 64 && age <= 122) priceTicket = 10;
            }
            if(priceTicket==0) { Console.WriteLine("Error!"); return; }
            Console.WriteLine(priceTicket+"$");
        }
    }
}