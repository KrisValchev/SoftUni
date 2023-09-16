using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int intelligenceValue = int.Parse(Console.ReadLine());
            int totalPriceOfBullets = 0;
            while (locks.Count > 0)
            {
                int barrelSize = gunBarrelSize;
                while (barrelSize != 0)
                {
                    if (bullets.Peek() <= locks.Peek())
                    {
                        Console.WriteLine("Bang!");
                        locks.Dequeue();
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                    }
                    bullets.Pop();
                    totalPriceOfBullets += priceOfBullet;
                    barrelSize--;
                    if (bullets.Count == 0 && locks.Count > 0)
                    {
                        Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                        return;
                    }
                    if(locks.Count==0)
                    {
                        break;
                    }
                }
                if (bullets.Count > 0 && barrelSize==0)
                {
                    Console.WriteLine("Reloading!");
                }
            }
            Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligenceValue - totalPriceOfBullets}");
        }
    }
}
