using System;
using System.Net.Http.Headers;
using System.Text;

namespace DirectoryTraversal
{
    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";
            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);
            WriteReportToDesktop(reportContent, reportFileName);
        }
        public static string TraverseDirectory(string inputFolderPath)
        {
            Dictionary<string, Dictionary<string, double>> extensionsAndFiles = new Dictionary<string, Dictionary<string, double>>();
            string[] files = Directory.GetFiles(inputFolderPath);
            Dictionary<string, double> filesAndSize = new Dictionary<string, double>();
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                if(!extensionsAndFiles.ContainsKey(info.Extension))
                {
                    extensionsAndFiles.Add(info.Extension,new Dictionary<string, double>());
                    extensionsAndFiles[info.Extension].Add(info.Name, info.Length / 1024.0);
                }
                else
                {
                    extensionsAndFiles[info.Extension].Add(info.Name, info.Length / 1024.0);
                }
            }
            StringBuilder text = new StringBuilder();
            foreach (var extension in extensionsAndFiles.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                text.AppendLine(extension.Key);
                foreach (var file in extension.Value.OrderBy(x=>x.Key))
                {
                    text.AppendLine($"--{file.Key} - {file.Value}kb");
                }
            }
            return text.ToString().TrimEnd();
        }
        public static void WriteReportToDesktop(string textContent, string
       reportFileName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(desktopPath,textContent);
        }
    }
}
