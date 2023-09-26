using System.Net.Http.Headers;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            CalculateWordCounts(wordPath, textPath, outputPath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string
       textFilePath, string outputFilePath)
        {
            Dictionary<string, int> wordsAndCounts = new Dictionary<string, int>();
            string[] words;
            using (StreamReader reader = new StreamReader(wordsFilePath))
            {
                words = File.ReadAllText(wordsFilePath).Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            for (int i = 0; i < words.Length; i++)
            {
                wordsAndCounts.Add(words[i], 0);
                using (StreamReader textReader = new StreamReader(textFilePath))
                {
                    string[] wordsFromTextFile = File.ReadAllText(textFilePath).Split(new char[]{ ' ', '.', ',', '-', '?', '!' });
                    for (int j = 0; j < wordsFromTextFile.Length; j++)
                    {
                        if (wordsAndCounts.ContainsKey(wordsFromTextFile[j].ToLower()))
                        {
                            wordsAndCounts[wordsFromTextFile[j].ToLower()]++;
                        }
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var wordAndCount in wordsAndCounts.OrderByDescending(x=>x.Value))
                {

                    writer.WriteLine($"{wordAndCount.Key} - {wordAndCount.Value}");
                }
            }
        }
    }
}
