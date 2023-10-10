namespace _07.Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameAndAddress = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            CustomTuple<string,string> nameAndAddressTuple = new CustomTuple<string,string>(nameAndAddress[0] + " " + nameAndAddress[1], nameAndAddress[2]);
            Console.WriteLine(nameAndAddressTuple.Item1+" -> "+nameAndAddressTuple.Item2);
            string[] nameAndBeers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            CustomTuple<string, int> nameAndBeersTuple = new CustomTuple<string, int>(nameAndBeers[0], int.Parse(nameAndBeers[1]));
            Console.WriteLine(nameAndBeersTuple.Item1 + " -> " + nameAndBeersTuple.Item2);
            string[] integerAndDouble = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            CustomTuple<int, double> integerAndDoubleTuple = new CustomTuple<int, double>(int.Parse(integerAndDouble[0]), double.Parse(integerAndDouble[1]));
            Console.WriteLine(integerAndDoubleTuple.Item1 + " -> " + integerAndDoubleTuple.Item2);


        }
    }
}