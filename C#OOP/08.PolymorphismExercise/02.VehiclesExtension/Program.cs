using _02.VehiclesExtension.Interface;
using _02.VehiclesExtension.Models;

namespace _02.VehiclesExtension
{
    public class StartUp
    {
        static void Main(string[] args)
        {
                string[] carTokens = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]), double.Parse(carTokens[3]));
                string[] truckTokens = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]), double.Parse(truckTokens[3]));
                string[] busTokens = Console.ReadLine().Split();
                Vehicle bus = new Bus(double.Parse(busTokens[1]), double.Parse(busTokens[2]), double.Parse(busTokens[3]));
                List<Vehicle> vehicles = new List<Vehicle>
           {
               car, truck, bus
           };
                int lines = int.Parse(Console.ReadLine());
                ICarable vehicle;
                for (int i = 0; i < lines; i++)
                {
                    try
                    {
                        string[] command = Console.ReadLine().Split();
                        if (command[0] == "Drive")
                        {
                            vehicle = vehicles.Find(v => v.GetType().Name == command[1]);
                            Drive(vehicle, double.Parse(command[2]));
                        }
                        else if (command[0] == "Refuel")
                        {
                            vehicle = vehicles.Find(v => v.GetType().Name == command[1]);
                            Refuel(vehicle, double.Parse(command[2]));
                        }
                        else
                        {
                        bus.Drive(double.Parse(command[2]), false);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                Console.WriteLine($"Car: {car.FuelQuantity:f2}");
                Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
                Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
            
        }
        static void Drive(ICarable vehicle, double distance)
        {
            vehicle.Drive(distance);
        }
        static void Refuel(ICarable vehicle, double quantity)
        {
            vehicle.Refuel(quantity);
        }

    }
}