namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            RewriteFileWithLineNumbers(inputPath, outputPath);
        }
        public static void RewriteFileWithLineNumbers(string inputFilePath, string
       outputFilePath)
        {
            using(StreamReader reader=new StreamReader(inputFilePath))
            {
                int numLine = 1;
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line=reader.ReadLine();  
                        writer.WriteLine(numLine+". "+ line);
                        numLine++;
                    }
                }
            }
        }
    }
}
