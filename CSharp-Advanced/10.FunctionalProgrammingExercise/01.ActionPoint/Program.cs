using System.Threading.Channels;

namespace _01.ActionPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> printNames = x => Console.WriteLine(x);
            foreach (var name in Console.ReadLine().Split())
            {
                printNames(name);
            }
        }
    }
}