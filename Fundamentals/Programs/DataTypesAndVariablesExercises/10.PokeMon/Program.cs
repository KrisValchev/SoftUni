namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int countOfPokedTargets = 0;
            int originalPokePower = pokePower;
            while(pokePower>=distance)
            {
                pokePower -= distance;
                countOfPokedTargets++;
                if (originalPokePower * 0.5 == pokePower && exhaustionFactor!=0)
                {
                    pokePower /= exhaustionFactor;
                }  
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(countOfPokedTargets);
        }
    }
}