namespace _10.RageExpanses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            float priceOfHeadset = float.Parse(Console.ReadLine());
            float priceOfMouse = float.Parse(Console.ReadLine());
            float priceOfKeyboard = float.Parse(Console.ReadLine());
            float priceOfDisplay = float.Parse(Console.ReadLine());
            int trashHeadset = 0;
            int trashMouse = 0;
            int trashKeyboard = 0;
            int trashDisplay = 0;
            trashHeadset = lostGames / 2;
            trashMouse = lostGames / 3;
            trashKeyboard = lostGames / 6;
            trashDisplay = lostGames / 12;
            
            Console.WriteLine($"Rage expenses: {(priceOfHeadset*trashHeadset+trashKeyboard*priceOfKeyboard+trashMouse*priceOfMouse+trashDisplay*priceOfDisplay):f2} lv.");
        }
    }
}