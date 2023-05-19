namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint startingYield = uint.Parse(Console.ReadLine());
            uint totalAmount = 0;
            uint workingDays = 0;
            if(startingYield<100)
            {
                Console.WriteLine(workingDays);
                Console.WriteLine(totalAmount);
                return;
            }
            while (startingYield>=100)
            {
                uint totalYieldPerDay = startingYield;
                totalYieldPerDay -= 26;
                startingYield -= 10;
                totalAmount += totalYieldPerDay;
                workingDays++;
            }
            totalAmount -= 26;
            Console.WriteLine(workingDays);
            Console.WriteLine(totalAmount);

        }
    }
}