using _01.Vehicles.Interface;
using _01.Vehicles.Models;

namespace _01.Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carTokens = Console.ReadLine().Split();
            ICarable car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]));
            string[] truckTokens = Console.ReadLine().Split();
            ICarable truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]));
            ICarable vehicle;
            int lines =int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0]=="Drive")
                {
                    if (command[1]=="Car")
                    {
                        vehicle = car;
                    }
                    else
                    {
                        vehicle = truck;
                    }
                        Drive(vehicle, double.Parse(command[2]));
                }
                else
                {
                    if (command[1] == "Car")
                    {
                        vehicle = car;
                    }
                    else
                    {
                        vehicle = truck;
                    }
                        Refuel(vehicle, double.Parse(command[2]));
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
        static void Drive(ICarable vehicle,double distance)
        {
           vehicle.Drive(distance);
        }
        static void Refuel(ICarable vehicle,double quantity)
        {
            vehicle.Refuel(quantity);
        }
    }
}