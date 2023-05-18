namespace _07.ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1=Console.ReadLine();
            string name2=Console.ReadLine();
            string delimiter=Console.ReadLine();
            string combine = name1 + delimiter + name2;
            Console.WriteLine(combine);


        }
    }
}