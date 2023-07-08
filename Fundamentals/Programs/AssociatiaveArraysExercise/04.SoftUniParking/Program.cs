using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<CarUser> carUsers = new List<CarUser>();
            for (int i = 0; i < lines; i++)
            {
                string[] command = Console.ReadLine().Split();
                string name = command[1];
                switch (command[0])
                {
                    case "register":
                        string licensePlateNumber = command[2];
                CarUser carUser = new CarUser(name, licensePlateNumber);
                        if (!carUsers.Exists(x=>x.Name==name))
                        {

                            carUsers.Add(carUser);
                            Console.WriteLine($"{name} registered {licensePlateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        }
                        break;
                    case "unregister":
                        if (carUsers.Exists(x => x.Name == name))
                        {
                            carUsers.RemoveAll(x=>x.Name==name);
                            Console.WriteLine($"{name} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        break;
                }
            }
            foreach (var carUser in carUsers)
            {
                Console.WriteLine($"{carUser.Name} => {carUser.LicensePlateNumber}");
            }
        }
    }
    class CarUser
    {
        public CarUser(string name,string licensePlateNumber)
        {
            LicensePlateNumber = licensePlateNumber;
            Name = name;
        }

        public string Name { get; set; }
        public string LicensePlateNumber { get; set; }
    }
}
