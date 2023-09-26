
namespace EvenLines
{
    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            Console.WriteLine(ProcessLines(inputFilePath));
        }
        static string text="";
        public static string ProcessLines(string inputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int lineNumber = 0;
                while (reader.EndOfStream == false)
                {
                    string content = reader.ReadLine();
                    if (lineNumber % 2 == 0)
                    {
                        text+=content+"\n";
                    }
                    lineNumber++;
                }

            }
            char[] characters = new char[] {'-', ',', '.', '!', '?' };
            foreach (var character in characters)
            {
                text = text.Replace(character, '@');
            }
            string[] lines = text.Split("\n");
            text = "";
            foreach (var line in lines)
            {
                string[] reversedLine = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
                text += string.Join(" ",reversedLine) + "\n";
            }
            return text.TrimEnd();
        }
    }
}
