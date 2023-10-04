using System.Threading.Tasks.Dataflow;

namespace _06.SpeedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount =double.Parse(input[1]);
                double fuelConsumptionPerKilometer= double.Parse(input[2]);
                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                cars.Add(car);
            }
            string command;
            while ((command =Console.ReadLine())!="End")
            {
                string model = command.Split()[1];
                double distanceToTravel = int.Parse(command.Split()[2]);
                cars.Find(x => x.Model == model).TravelDistance(distanceToTravel);
            }
            Console.WriteLine(string.Join(Environment.NewLine,cars));
        }
    }
    class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;
        public Car()
        {
            this.TravelledDistance = 0;
        }
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer) : this()
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }
        public double TravelledDistance
        {
            get { return travelledDistance; }
            set { travelledDistance = value; }
        }

        public double FuelConsumptionPerKilometer
        {
            get { return fuelConsumptionPerKilometer; }
            set { fuelConsumptionPerKilometer = value; }
        }

        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public void TravelDistance(double amountOfKm)
        {
            if(this.FuelAmount-this.FuelConsumptionPerKilometer*amountOfKm>=0)
            {
                this.FuelAmount -= this.FuelConsumptionPerKilometer * amountOfKm;
                this.TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.TravelledDistance}";
        }
    }
}