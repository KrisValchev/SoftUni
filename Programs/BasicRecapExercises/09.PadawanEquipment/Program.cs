using System.Xml;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amoutOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());
            double totalPriceOfLightSabers = Math.Ceiling(countOfStudents * 1.1) * priceOfLightsaber;
            double countOfFreeBelts =(countOfStudents / 6);
            double totalPriceOfBelts = (countOfStudents -countOfFreeBelts) * priceOfBelt;
            double totalMoney = totalPriceOfBelts + totalPriceOfLightSabers + countOfStudents * priceOfRobe;
            if(totalMoney<=amoutOfMoney) Console.WriteLine($"The money is enough - it would cost {totalMoney:f2}lv.");
            else Console.WriteLine($" John will need {(totalMoney-amoutOfMoney):f2}lv more."
);

        }
    }
}