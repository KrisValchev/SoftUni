using System;
using System.Linq;
using System.Collections.Generic;
namespace _07.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
           HashSet<string> carNumbers = new HashSet<string>();
            while ((command = Console.ReadLine()) != "END")
            {
                string[] directionAndNumber = command.Split(", ");
                string direction = directionAndNumber[0];
                string carNumber = directionAndNumber[1];
                if(direction=="IN")
                {
                    carNumbers.Add(carNumber);
                }
                else
                {
                    carNumbers.Remove(carNumber);
                }
            }
            if (carNumbers.Count > 0)
            {
                foreach (var car in carNumbers)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
