namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort fieldSize = ushort.Parse(Console.ReadLine());
            if (fieldSize > 1000) return;
            int[] ladyBugsPositions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < ladyBugsPositions.Length; j++)
                {
                    if (i == ladyBugsPositions[j])
                    {
                        field[i] = 1;
                    }
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") break;
                string[] command = input.Split();
                int ladyBugIndex = int.Parse(command[0]);
                if (ladyBugIndex >= fieldSize || ladyBugIndex < 0) continue;
                string direction = command[1];
                int flyLenght = int.Parse(command[2]);
                if (flyLenght == 0) continue;
                int newFlyLenght = 0;
                if (direction == "right")
                {
                    newFlyLenght = ladyBugIndex + flyLenght;
                    while (field[ladyBugIndex] != 0)
                    {
                        if (newFlyLenght < 0 || newFlyLenght >= fieldSize)
                        {
                            field[ladyBugIndex] = 0;
                            break;
                        }
                        if (field[newFlyLenght] == 0)
                        {
                            field[ladyBugIndex] = 0;
                            field[newFlyLenght] = 1;
                            break;
                        }
                        newFlyLenght += flyLenght;
                    }
                }
                if (direction == "left")
                {
                    newFlyLenght = ladyBugIndex - flyLenght;
                    while (field[ladyBugIndex] != 0)
                    {
                        if (newFlyLenght < 0 || newFlyLenght >= fieldSize)
                        {
                            field[ladyBugIndex] = 0;
                            break;
                        }
                        if (field[newFlyLenght] == 0)
                        {
                            field[ladyBugIndex] = 0;
                            field[newFlyLenght] = 1;
                            break;
                        }
                        newFlyLenght -= flyLenght;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}