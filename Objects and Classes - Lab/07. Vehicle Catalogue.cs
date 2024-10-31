using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> vehicle = input.Split("/").ToList();

                string type = vehicle[0];
                string brand = vehicle[1];
                string model = vehicle[2];
                string power = vehicle[3];

                if(type == "Car")
                {
                    catalog.Cars.Add(new Car(brand, model, power));
                }

                else if (type == "Truck")
                {
                    catalog.Trucks.Add(new Truck(brand, model, power));
                }
            }
            
            if(catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach(Car c in catalog.Cars.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{c.Brand}: {c.Model} - {c.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck t in catalog.Trucks.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{t.Brand}: {t.Model} - {t.Weight}kg");
                }
            }
        }
        class Truck
        {
            public Truck(string brand, string model, string weight)
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Weight { get; set; }
        }
        class Car
        {
            public Car(string brand, string model, string horsePower)
            {
                Brand = brand;
                Model = model;
                HorsePower = horsePower;
            }
            public string Brand { get; set; }
            public string Model { get; set; }
            public string HorsePower { get; set; }
        }
        class Catalog
        {
            public List<Car> Cars { get; }
            public List<Truck> Trucks { get; }

            public Catalog()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }
        }
    }
}