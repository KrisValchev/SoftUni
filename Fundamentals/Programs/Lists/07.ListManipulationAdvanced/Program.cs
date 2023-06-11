using System.Globalization;

namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();
            bool madeChanges = false;
            while (true)
            {
                string line = Console.ReadLine();
               if(line=="end")
                {
                    if(madeChanges) Console.WriteLine(string.Join(" ",numbers));
                    break;
                }
                string[] tokens = line.Split();
                switch(tokens[0])
                {

                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        madeChanges = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        madeChanges = true;
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemove);
                        madeChanges = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert,numberToInsert);
                        madeChanges = true;
                        break;
                }
                switch (tokens[0])
                {
                    case "Contains":
                        int number= int.Parse(tokens[1]);
                        if(numbers.Contains(number))
                            Console.WriteLine("Yes");
                        else
                            Console.WriteLine("No such number");
                        break;
                    case "PrintEven":
                        List<int> even = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i]%2==0)
                                even.Add(numbers[i]);
                        }
                        Console.WriteLine(string.Join(" ",even));
                        break;
                    case "PrintOdd":
                        List<int> odd = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                                odd.Add(numbers[i]);
                        }
                        Console.WriteLine(string.Join(" ", odd));
                        break;
                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = tokens[1];
                        int numberToFilter = int.Parse(tokens[2]);
                        List<int> conditionalNumbers = new List<int>();
                        switch (condition)
                        {
                            case "<":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] < numberToFilter)
                                        conditionalNumbers.Add(numbers[i]);
                                }
                                break;
                            case ">":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] > numberToFilter)
                                        conditionalNumbers.Add(numbers[i]);
                                }
                                break;
                            case ">=":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] >= numberToFilter)
                                        conditionalNumbers.Add(numbers[i]);
                                }
                                break;
                            case "<=":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] <= numberToFilter)
                                        conditionalNumbers.Add(numbers[i]);
                                }
                                break;
                        }
                        Console.WriteLine(  string.Join(" ",conditionalNumbers));
                        break;
                }
            }
        }
    }
}