
using System.Security;

namespace _11.ArrayManipulator
{
    internal class Program
    {
        static int[] numbers;
        static void Main(string[] args)
        {
            numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    Console.WriteLine($"[{string.Join(", ", numbers)}]");
                    break;
                }
                string[] command = input.Split();
                if (command[0] == "exchange")
                {
                    ExchangeAtIndex(int.Parse(command[1]), numbers);
                }
                else if (command[0] == "max")
                {
                    if (command[1]=="even")
                    {
                        MaxEven(numbers);
                    }
                    else
                    {
                        MaxOdd(numbers);
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        MinEven(numbers);
                    }
                    else
                    {
                        MinOdd(numbers);
                    }
                }
                else if (command[0] == "first")
                {
                    if (command[2]=="even")
                    {
                        FirstCountEven(int.Parse(command[1]), numbers);
                    }
                    else
                    {
                        FirstCountOdd(int.Parse(command[1]), numbers);
                    }
                }
                else
                {
                    if (command[2] == "even")
                    {
                        LastCountEven(int.Parse(command[1]), numbers);
                    }
                    else
                    {
                        LastCountOdd(int.Parse(command[1]), numbers);
                    }
                }
            }
        }
        static void ExchangeAtIndex(int index, int[] array)
        {
            if (index >= array.Length || index<0) Console.WriteLine("Invalid index");
            int indexOfNumberToMove = 0;
            for (int i = index + 1; i < array.Length; i++)
            {

                for (int j = i - 1; j >= indexOfNumberToMove; j--)
                {
                    int currentNumber = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = currentNumber;
                }
                indexOfNumberToMove++;
            }
            numbers = array;
        }
        static void MinEven(int[] array)
        {
            int minValue = int.MaxValue;
            int indexOfMinValue = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] <= minValue)
                    {
                        minValue = array[i];
                        indexOfMinValue = i;
                    }
                }
            }
            if(minValue!=int.MaxValue) Console.WriteLine(indexOfMinValue);
            else Console.WriteLine("No matches");
        }
        static void MinOdd(int[] array)
        {
            int minValue = int.MaxValue;
            int indexOfMinValue = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] <= minValue)
                    {
                        minValue = array[i];
                        indexOfMinValue = i;
                    }
                }
            }
            if (minValue != int.MaxValue) Console.WriteLine(indexOfMinValue);
            else Console.WriteLine("No matches");
        }
        static void MaxEven(int[] array)
        {
            int maxValue = int.MinValue;
            int indexOfMaxValue = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] >= maxValue)
                    {
                        maxValue = array[i];
                        indexOfMaxValue = i;
                    }
                }
            }
            if (maxValue != int.MinValue) Console.WriteLine(indexOfMaxValue);
            else Console.WriteLine("No matches");
        }
        static void MaxOdd(int[] array)
        {
            int maxValue = int.MinValue;
            int indexOfMaxValue = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] >= maxValue)
                    {
                        maxValue = array[i];
                        indexOfMaxValue = i;
                    }
                }
            }
            if (maxValue != int.MinValue) Console.WriteLine(indexOfMaxValue);
            else Console.WriteLine("No matches");
        }
        static void FirstCountEven(int count, int[] array)
        {
            if(count>array.Length) Console.WriteLine("Invalid count");
            else
            {
                int countOfCurrentNumbers = 0;
                string[] numbersArray;
                string numbers = "";
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i]%2==0)
                    {
                        countOfCurrentNumbers++;
                        numbers += array[i] + " ";
                        if (countOfCurrentNumbers == count) break;
                    }
                }
                numbers = numbers.TrimEnd();
                numbersArray = numbers.Split();
                Console.WriteLine($"[{string.Join(", ", numbersArray)}]");
            }
        }
        static void FirstCountOdd(int count, int[] array)
        {
            if (count > array.Length) Console.WriteLine("Invalid count");
            else
            {
                int countOfCurrentNumbers = 0;
                string[] numbersArray;
                string numbers = "";
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        countOfCurrentNumbers++;
                        numbers += array[i] + " ";
                        if (countOfCurrentNumbers == count) break;
                    }
                }
                numbers = numbers.TrimEnd();
                numbersArray = numbers.Split();
                Console.WriteLine($"[{string.Join(", ", numbersArray)}]");
            }
        }
        static void LastCountEven(int count, int[] array)
        {
            if (count > array.Length) Console.WriteLine("Invalid count");
            else
            {
                int countOfCurrentNumbers = 0;
                 string[] numbersArray;
                string numbers = "";
                for (int i = array.Length-1; i >=0; i--)
                {
                    if (array[i] % 2 == 0)
                    {
                        countOfCurrentNumbers++;
                        numbers += array[i]+" ";
                        if (countOfCurrentNumbers == count) break;
                    }
                }
                numbers = numbers.TrimEnd();
                numbersArray = numbers.Split();
                Console.WriteLine($"[{string.Join(", ", numbersArray.Reverse())}]");
            }
        }
        static void LastCountOdd(int count, int[] array)
        {
            if (count > array.Length) Console.WriteLine("Invalid count");
            else
            {
                int countOfCurrentNumbers = 0;
                 string[] numbersArray;
                string numbers = "";
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] % 2 != 0)
                    {
                        countOfCurrentNumbers++;
                        numbers += array[i]+" ";
                        if (countOfCurrentNumbers == count) break;
                    }
                }
                numbers = numbers.TrimEnd();
                numbersArray = numbers.Split();
                Console.WriteLine($"[{string.Join(", ",numbersArray.Reverse())}]");
            }
        }
    }
}