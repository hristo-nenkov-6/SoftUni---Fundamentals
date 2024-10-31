using System;
using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Xml.Schema;

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
                int engSpeed = int.Parse(input[1]);
                int engPower = int.Parse(input[2]);
                int cargWeight = int.Parse(input[3]);
                string cargType = input[4];

                Engine engine = new Engine(engSpeed, engPower);
                Cargo cargo = new Cargo(cargWeight, cargType);
                Car car = new Car(model, engine, cargo);

                cars.Add(car);
            }
            string f_f = Console.ReadLine();
            if(f_f == "fragile")
            {
                foreach(Car car in cars.Where(car => car.Cargo.CargoWeight < 1000))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                foreach (Car car in cars.Where(car => car.Engine.EnginePower > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
        class Car
        {
            public Car(string model, Engine engine, Cargo cargo)
            {
                Model = model;
                Engine = engine;
                Cargo = cargo;
            }
            public string Model { get; set; }
            public Engine Engine { get; set; }
            public Cargo Cargo { get; set; }

        }
        class Engine
        {
            public Engine(int engineSpeed, int enginePower)
            {
                EngineSpeed = engineSpeed;
                EnginePower = enginePower;
            }
            public int EngineSpeed { get; set; }
            public int EnginePower { get; set; }
        }
        class Cargo
        {
            public Cargo(int cargoWeight, string cargoType)
            {
                CargoWeight = cargoWeight;
                CargoType = cargoType;
            }
            public int CargoWeight { get; set; }
            public string CargoType { get; set; }
        }
    }
}