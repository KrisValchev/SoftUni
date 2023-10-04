
namespace _08.CarSalesmn
{
    public class StartUp
    {
        static void Main()
        {
            int engineLines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            for (int i = 0; i < engineLines; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                int power = int.Parse(input[1]);
                Engine engine = new Engine(model, power);

                if (input.Length > 2)
                {
                    int displacement;
                    bool isDigit = int.TryParse(input[2], out displacement);
                    if (isDigit)
                    {
                        displacement = int.Parse(input[2]);
                        engine.Displacement = displacement;

                    }
                    else
                    {
                        string efficiency = input[2];
                        engine.Efficiency = efficiency;
                    }
                }
                if (input.Length > 3)
                {
                    string efficiency = input[3];
                    engine.Efficiency = efficiency;
                }
                engines.Add(engine);
            }
            int carLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < carLines; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                Engine engine = engines.Find(x => x.Model == input[1]);
                Car car = new Car(model, engine);
                if (input.Length > 2)
                {
                    int weight;
                    bool isDigit = int.TryParse(input[2], out weight);
                    if (isDigit)
                    {
                        weight = int.Parse(input[2]);
                        car.Weight = weight;
                    }
                    else
                    {
                        string color = input[2];
                        car.Color = color;
                    }
                }
                if (input.Length > 3)
                {
                    string color = input[3];
                    car.Color = color;
                }
                cars.Add(car);
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}