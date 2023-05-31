namespace _05.LongestIncreasingSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] len = new int[num.Length ];
            int[] prev = new int[num.Length];
            int maxLength = 0;
            int lastIndex = -1;
            for (int p = 0; p < num.Length; p++)
            {
                len[p] = 1;
                prev[p] =-1;
                for (int left = 0; left < p; left++)
                {
                    if (num[p] > num[left]&& len[p]<=len[left])
                    {
                        len[p] = 1 + len[left];
                        prev[p] = left;
                    }
                }
                if (len[p] > maxLength)
                {
                    maxLength = len[p];
                    lastIndex = p;
                }
            }
            int[] LIS = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                LIS[i] = num[lastIndex];
                lastIndex = prev[lastIndex];
            }
            Array.Reverse(LIS);
            Console.WriteLine(string.Join(" ",LIS));
        }
    }
}