using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = Console.ReadLine().Split("\\");
            string[] fileNameAndExtension = file[file.Length - 1].Split(".");
            Console.WriteLine("File name: "+ fileNameAndExtension[0]);
            Console.WriteLine("File extension: "+ fileNameAndExtension[1]);
        }
    }
}
