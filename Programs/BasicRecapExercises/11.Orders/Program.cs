namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for (int i = 0; i < orders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount= int.Parse(Console.ReadLine());
                double pricePerMonth = ((days * capsuleCount) * pricePerCapsule);
                totalPrice += pricePerMonth;
                Console.WriteLine($"The price for the coffee is: ${pricePerMonth:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}