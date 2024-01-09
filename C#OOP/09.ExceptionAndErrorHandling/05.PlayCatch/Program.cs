using System.Reflection.Metadata.Ecma335;

namespace _05.PlayCatch
{
    internal class Program
    {
        static int[] integers;
        static void Main(string[] args)
        {
            int exceptions = 0;
            integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (exceptions != 3)
            {
                try
                {
                    string[] command = Console.ReadLine().Split();
                    if (command[0] == "Replace")
                    {
                        int index = int.Parse(command[1]);
                        int element = int.Parse(command[2]);
                        integers[index] = element;
                    }
                    else if (command[0] == "Print")
                    {
                        int index = int.Parse(command[1]);
                        int index2 = int.Parse(command[2]);
                        if (index2 >= integers.Length)
                            throw new IndexOutOfRangeException();
                        for (int i = index; i < index2; i++)
                        {
                            Console.Write($"{integers[i]}, ");
                        }
                        Console.WriteLine(integers[index2]);
                    }
                    else
                    { int index = int.Parse(command[1]);
                        Console.WriteLine(integers[index]); 
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptions++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptions++;
                }
            }
            Console.WriteLine(string.Join(", ",integers));
        }
        static bool CheckIndex(int index)
        {
            if (index < 0 || index >= integers.Length)
                return false;
            return true;
        }

    }
}