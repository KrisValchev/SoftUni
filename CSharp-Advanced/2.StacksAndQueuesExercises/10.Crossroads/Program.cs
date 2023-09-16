using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLineDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);

                }
                else
                {
                    int freeWindow = freeWindowDuration;
                    int greenLine = greenLineDuration;
                    string car;
                    while (greenLine > 0 && cars.Any())
                    {
                        car = cars.Dequeue();
                        if (greenLine - car.Length >= 0)
                        {
                            passedCars++;
                            greenLine = greenLine - car.Length;
                        }
                        else if (freeWindow + greenLine - car.Length >= 0)
                        {
                            passedCars++;
                            break;
                        }
                        else
                        {
                            string happenedCrashCharacter = car.Substring(freeWindow + greenLine, 1);
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{car} was hit at {happenedCrashCharacter}.");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");

        }
    }
}
