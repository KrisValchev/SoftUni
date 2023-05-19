using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            BigInteger highestSnowballValue = 0;
            int saveSnowballSnow = 0;
            int saveSnowballTime = 0;
            int saveSnowballQuality = 0;
            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (snowballValue > highestSnowballValue)
                {
                    highestSnowballValue = snowballValue;
                    saveSnowballQuality = snowballQuality;
                    saveSnowballSnow = snowballSnow;
                    saveSnowballTime = snowballTime;
                }
            }
            Console.WriteLine($"{saveSnowballSnow} : {saveSnowballTime} = {highestSnowballValue} ({saveSnowballQuality})");
        }
    }
}