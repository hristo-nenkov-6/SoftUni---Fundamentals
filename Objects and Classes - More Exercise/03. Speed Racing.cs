using System;
using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;


namespace ConsoleApp3
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptPerKilom = double.Parse(input[2]);
                double travelledDist = 0;
                Car car = new Car(model, fuelAmount, fuelConsumptPerKilom, travelledDist);
                cars.Add(car);
            }

            string inp = string.Empty;
            while((inp = Console.ReadLine()) != "End")
            {
                string[] inpp = inp.Split(" ").ToArray();
                string model = inpp[1];
                double kilomToDrive = double.Parse(inpp[2]);

                bool isDrive = inpp[0].Equals("Drive");
                if(isDrive)
                {
                    Car currentCar = cars.Find(car => car.Model == model);
                    currentCar.CheckIfFuelIsEnough_Drive(currentCar.FuelAmount, currentCar.FuelConsumptPerKilom,
                                                            kilomToDrive);
                }
                else
                {
                    break;
                }
            }

            foreach(Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
        class Car
        {
            public Car(string model, double fuelAmount, double fuelConsumptPerKilom, double travelledDistance)
            {
                Model = model;
                FuelAmount = fuelAmount;
                FuelConsumptPerKilom = fuelConsumptPerKilom;
                TravelledDistance = travelledDistance;
            }
            public string Model { get; set; }
            public double FuelAmount { get; set; }
            public double FuelConsumptPerKilom { get; set; }
            public double TravelledDistance { get; set; }
            public void CheckIfFuelIsEnough_Drive(double fuelAmountn, double fuelConsPerKilom ,double distanceToTravel)
            {
                if(fuelAmountn / fuelConsPerKilom >= distanceToTravel)
                {
                    FuelAmount -= distanceToTravel * fuelConsPerKilom;
                    TravelledDistance += distanceToTravel;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
            public override string ToString()
            {
                return $"{Model} {FuelAmount:f2} {TravelledDistance}";
            }
        }
    }
}