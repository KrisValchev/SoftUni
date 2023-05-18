namespace _01.Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            if(age>=0&&age<=2) Console.WriteLine("baby");
            if(age>2&&age<=13) Console.WriteLine("child");
            if(age>13&&age<=19) Console.WriteLine("teenager");
            if(age>19&&age<=65) Console.WriteLine("adult");
            if(age>65) Console.WriteLine("elder");
        }
    }
}