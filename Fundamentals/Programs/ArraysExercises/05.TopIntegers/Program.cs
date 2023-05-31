namespace _05.TopIntegers
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string integersGreaterThenElementsToItsRight = string.Empty;
            for (int i = 0; i < numbers.Length-1; i++)
            { 
            bool isItGrater = false;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j]) isItGrater = true;
                    else
                    {
                        isItGrater = false;
                        break;
                    }
                }
                if (isItGrater)
                    integersGreaterThenElementsToItsRight += numbers[i] + " ";
            }
            Console.WriteLine(integersGreaterThenElementsToItsRight + numbers[numbers.Length-1]);
        }
    }
}