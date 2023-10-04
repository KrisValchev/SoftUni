using System.Threading.Tasks.Dataflow;

namespace _07.RawData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < number; i++)
            {
                string[] carProps = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car(
               carProps[0],
               int.Parse(carProps[1]),
               int.Parse(carProps[2]),
               int.Parse(carProps[3]),
               carProps[4],
               double.Parse(carProps[5]),
               int.Parse(carProps[6]),
               double.Parse(carProps[7]),
               int.Parse(carProps[8]),
               double.Parse(carProps[9]),
               int.Parse(carProps[10]),
               double.Parse(carProps[11]),
               int.Parse(carProps[12])
               );
                cars.Add(car);
            }
            string command =Console.ReadLine();
            if(command=="fragile")
            {
                Console.WriteLine(string.Join
                    (Environment.NewLine,
                    cars.Where(x=>x.Cargo.Type==command && x.Tires.Any(x=>x.Pressure<1))
                    .Select(x=>x.Model)
                    .ToList()));
            }
            else
            {
                Console.WriteLine(string.Join
                    (Environment.NewLine,
                    cars.Where(x => x.Cargo.Type == command && x.Engine.HorsePower>250)
                    .Select(x => x.Model)
                    .ToList()));
            }
        }
    }
    public class Car
    {
        private string model;
        private Engine engine;
        private Tire[] tires;
        private Cargo cargo;

        public Cargo Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }
       
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public Car(string model, int engineSpeed,int enginePower,int cargoWeight, string cargoType, double tire1Pressure,int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            this.Model = model;
            this.Cargo = new Cargo(cargoWeight, cargoType);
           this.Engine = new Engine(enginePower,engineSpeed);
            this.Tires=new Tire[4]{ new Tire(tire1Pressure,tire1Age),new Tire(tire2Pressure, tire2Age), new Tire(tire3Pressure, tire3Age), new Tire(tire4Pressure, tire4Age)};
        }
    }
    public class Cargo
    {
        private string type;
        private int weight;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
    }
        public class Engine
    {
        private int horsePower;
        private int speed;

        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public Engine(int horsePower, int speed)
        {
            this.HorsePower = horsePower;
            this.Speed = speed;
        }

    }
    public class Tire
    {
        private int age;
        private double pressure;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }
        public Tire(double pressure,int age)
        {
            this.Age = age;
            this.Pressure = pressure;
        }
    }
}