using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;
        public int Count
        {
            get { return Cars.Count; }
            set { capacity = value; }
        }

        public List<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }
        public Parking(int capacity)
        {
            Count = capacity;
            Cars = new List<Car>(capacity);
        }
        public string AddCar(Car car)
        {
            if (Cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return ("Car with that registration number, already exists!");
            }
            else if (Cars.Count == capacity)
            {
                return ("Parking is full!");
            }
            else
            {
                Cars.Add(car);
                return ($"Successfully added new car {car.Make} {car.RegistrationNumber}");
            }
        }
        public string RemoveCar(string RegistrationNumber)
        {
            if (!Cars.Any(x => x.RegistrationNumber == RegistrationNumber))
            {
                return ("Car with that registration number, doesn't exist!");
            }
            else
            {
                Cars.Remove(Cars.Find(x => x.RegistrationNumber == RegistrationNumber));
                return ($"Successfully removed {RegistrationNumber}");
            }
        }
        public Car GetCar(string RegistrationNumber)
        {
            return Cars.Find(x => x.RegistrationNumber == RegistrationNumber);
        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var carRegistration in RegistrationNumbers)
            {
                if (Cars.Any(x => x.RegistrationNumber == carRegistration))
                {
                    Cars.Remove(Cars.Find(x => x.RegistrationNumber == carRegistration));
                }
            }
        }
    }
}
