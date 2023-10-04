namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            List<Tire[]>tiresPack=new List<Tire[]>();
            List<Engine> engines=new List<Engine>();
            List<Car> cars = new List<Car>();
            string command;
            while ((command =Console.ReadLine())!="No more tires")
            {
                Tire[] tire = new Tire[4];
                string[] tiresAndPressure = command.Split();
                int tireIndex = 0;
                for (int i = 0; i < 4; i++)
                {
                    int year = int.Parse(tiresAndPressure[tireIndex++]);
                    double pressure = double.Parse(tiresAndPressure[tireIndex++]);
                    tire[i]=new Tire(year, pressure);
                }
                tiresPack.Add(tire);
            }
            while ((command = Console.ReadLine()) != "Engines done")
            {
                string[] powerAndCapacity = command.Split();
                int horsePower = int.Parse(powerAndCapacity[0]);
                double cubicCapacity = double.Parse(powerAndCapacity[1]);
                Engine engine = new Engine(horsePower,cubicCapacity);
                engines.Add(engine);
            }
            while ((command = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = command.Split();
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);
                Tire[] tires = tiresPack[tiresIndex];
                Engine engine = engines[engineIndex];
                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires);
                cars.Add(car);
            }
            foreach (var car in cars.Where(x=>x.Year>=2017
            && x.Engine.HorsePower>330 
            && x.Tires.Select(x=>x.Pressure).Sum()>=9
            && x.Tires.Select(x => x.Pressure).Sum()<=10)
                .ToList())
            {
                car.Drive(20);
                Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}