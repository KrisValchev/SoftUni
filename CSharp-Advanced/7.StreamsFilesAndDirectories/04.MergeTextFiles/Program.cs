namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";
            MergeTextFiles(firstInputFilePath, secondInputFilePath,
           outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string
       secondInputFilePath, string outputFilePath)
        {
            using (StreamReader input1Reader = new StreamReader(firstInputFilePath))
            {
                using (StreamReader input2Reader = new StreamReader(secondInputFilePath))
                {
                    using(StreamWriter writer=new StreamWriter(outputFilePath))
                    {
                        int firstInputLinesCount = File.ReadLines(firstInputFilePath).Count();
                        int secondInputLinesCount = File.ReadLines(secondInputFilePath).Count();
                            string firstInputLine = input1Reader.ReadLine();
                            string secondInputLine = input2Reader.ReadLine();
                        if(firstInputLinesCount<secondInputLinesCount)
                        {
                           while (secondInputLine!=null)
                            {
                                if (firstInputLine != null)
                                {
                                    writer.WriteLine(firstInputLine);
                                }
                                writer.WriteLine(secondInputLine);
                                firstInputLine=input1Reader.ReadLine();
                                secondInputLine = input2Reader.ReadLine();
                            }
                        }
                        else
                        {
                            while (firstInputLine != null)
                            {
                                if (secondInputLine != null)
                                {
                                    writer.WriteLine(secondInputLine);
                                }
                                writer.WriteLine(firstInputLine);
                                firstInputLine = input1Reader.ReadLine();
                                secondInputLine = input2Reader.ReadLine();
                            }
                        }
                    }
                }
            }
        }
    }
}