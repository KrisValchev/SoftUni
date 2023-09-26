using System.Runtime.CompilerServices;

namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";
            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }
        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string
       bytesFilePath, string outputPath)
        {
            using (FileStream reader = new FileStream(binaryFilePath, FileMode.Open))
            {
                byte[] bytes = new byte[reader.Length];
                reader.Read(bytes, 0, bytes.Length);
                    List<byte> occurences = new List<byte>();
                using (FileStream bytesReader = new FileStream(bytesFilePath, FileMode.Open))
                {
                    byte[] buffer = new byte[bytesReader.Length];
                    bytesReader.Read(buffer,0,buffer.Length);
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        if (bytes.Contains(buffer[i]))
                        {
                            occurences.Add(buffer[i]);
                        }
                    }
                }
                using(FileStream writer = new FileStream(outputPath, FileMode.Create))
                {
                    writer.Write(occurences.ToArray(), 0, occurences.Count);
                }
            }

        }
    }
}