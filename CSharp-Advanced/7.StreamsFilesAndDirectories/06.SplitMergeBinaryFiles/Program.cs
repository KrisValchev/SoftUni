namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";
            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }
        public static void SplitBinaryFile(string sourceFilePath, string
       partOneFilePath, string partTwoFilePath)
        {
            using (FileStream reader = new FileStream(sourceFilePath, FileMode.Open))
            {
                byte[] part1 = new byte[(reader.Length+1)/2];
                reader.Read(part1, 0, part1.Length);
                using (FileStream part1Writer = new FileStream(partOneFilePath, FileMode.Create))
                {
                    part1Writer.Write(part1.ToArray(), 0, part1.Length);
                }
                byte[] part2 = new byte[(reader.Length)/2];
                reader.Read(part2, 0, part2.Length);
                using (FileStream part2Writer = new FileStream(partTwoFilePath, FileMode.Create))
                {
                    part2Writer.Write(part2.ToArray(), 0, part2.Length);
                }
            }
        }
        public static void MergeBinaryFiles(string partOneFilePath, string
       partTwoFilePath, string joinedFilePath)
        {
            using (var joinedFile = new FileStream(joinedFilePath, FileMode.Create))
            {
                using(var firstFile = new FileStream(partOneFilePath, FileMode.Open))
                {
                    byte[] buffer = new byte[firstFile.Length];
                    joinedFile.Write(buffer);
                }
                using (var secondFile = new FileStream(partTwoFilePath, FileMode.Open))
                {
                    byte[] buffer = new byte[secondFile.Length];
                    joinedFile.Write(buffer,0,buffer.Length);
                }
            }
        }
    }
}
