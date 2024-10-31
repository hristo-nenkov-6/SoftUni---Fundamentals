using System;
using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
/*
2
Gogo-Yantra
Hristo-Barca
Valio->Barca
Troro->Barca
Timo->Yantra
end of assignment
*/

namespace ConsoleApp3
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while((input = Console.ReadLine()) != "End")
            {
                string[] arrInput = input.Split(" ").ToArray();
                string typeOfVehicle = arrInput[0];
                string model = arrInput[1];
                string color = arrInput[2];
                double hp = double.Parse(arrInput[3]);
                if(typeOfVehicle == "car")
                {
                    Car Vc = new Car(model, color, hp);
                    cars.Add(Vc);
                }
                else if (typeOfVehicle == "truck")
                {
                    Truck Vt = new Truck(model, color, hp);
                    trucks.Add(Vt);
                }
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                string model = input;
                Car wantedCar = cars.Find(car => car.Model == model);
                if(wantedCar != null)
                {
                    Console.WriteLine($"Type: Car");
                    Console.WriteLine($"Model: {wantedCar.Model}");
                    Console.WriteLine($"Color: {wantedCar.Color}");
                    Console.WriteLine($"Horsepower: {wantedCar.Horsepower}");
                }
                else
                {
                    Truck wantedTruck = trucks.Find(truck => truck.Model == model);
                    Console.WriteLine($"Type: Truck");
                    Console.WriteLine($"Model: {wantedTruck.Model}");
                    Console.WriteLine($"Color: {wantedTruck.Color}");
                    Console.WriteLine($"Horsepower: {wantedTruck.Horsepower}");
                }
            }

            int ccount = cars.Count;
            int tcount = trucks.Count;
            if(cars.Count == 0)
            {
                ccount = 1;
            }
            if(trucks.Count == 0)
            {
                tcount = 1;
            }
            double avCarHp = 0;
            foreach( Car car in cars )
            {
                avCarHp += car.Horsepower;
            }
            Console.WriteLine($"Cars have average horsepower of: {avCarHp / ccount:f2}.");

            double avTruckHp = 0;
            foreach (Truck truck in trucks)
            {
                avTruckHp += truck.Horsepower;
            }

            Console.WriteLine($"Trucks have average horsepower of: {avTruckHp / tcount:f2}.");

        }
        class Car
        {
            public Car(string model, string color, double horsepower)
            {
                Model = model;
                Color = color;
                Horsepower = horsepower;
            }
            public string Model { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }
        }
        class Truck
        {
            public Truck(string model, string color, double horsepower)
            {
                Model = model;
                Color = color;
                Horsepower = horsepower;
            }
            public string Model { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }
        }
    }
}