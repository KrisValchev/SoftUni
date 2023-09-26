
namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";
            ExtractOddLines(inputFilePath, outputFilePath);
        }
        public static void ExtractOddLines(string inputFilePath, string
       outputFilePath)
        {

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int lineNumber = 0;
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    while (reader.EndOfStream == false)
                    {
                        string content = reader.ReadLine();
                        if (lineNumber % 2 != 0)
                        {
                            writer.WriteLine(content);
                        }
                        lineNumber++;
                    }
                }
            }
        }
    }
}