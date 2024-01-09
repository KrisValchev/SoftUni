using System.Security.AccessControl;

namespace _02.EnterNumber
{
    internal class Program
    {
           static int validNumbers = 0;
           static int index = 0;
          static  List<int> numbers = new List<int>();
        static void Main(string[] args)
        {
            while (validNumbers != 10)
            {
                if (numbers.Count == 0)
                {

                    ReadNumber(1, 100);
                }
                else
                {
                    ReadNumber(numbers.Max(), 100);
                }

            }
            Console.WriteLine(string.Join(", ", numbers));
        }
        static void ReadNumber(int start, int end)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());

                if (number > start && number < end)
                {
                    numbers.Add(number);
                    validNumbers++;
                    index++;
                }
                else
                {
                    throw new ArgumentException($"Your number is not in range {start} - 100!");
                }



            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch
            {
                Console.WriteLine("Invalid Number!");
            }

           
        }
    }
}