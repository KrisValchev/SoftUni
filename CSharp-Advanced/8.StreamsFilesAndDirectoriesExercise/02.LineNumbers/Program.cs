namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";
            ProcessLines(inputFilePath, outputFilePath);

        }
        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] text = File.ReadAllLines(inputFilePath);
            int line = 0;
            string[] newText = new string[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                int lettersCount = 0;
                int punctioationCount = 0;
                for (int j = 0; j < text[i].Length; j++)
                {
                    if (char.IsLetter(text[i][j]))
                    {
                        lettersCount++;
                    }
                    else if (!char.IsWhiteSpace(text[i][j]))
                    {
                        punctioationCount++;
                    }
                }
                newText[i] = $"Line {++line}: {text[i]} ({lettersCount})({punctioationCount})";
            }
            File.WriteAllLines(outputFilePath, newText);
        }

    }
}