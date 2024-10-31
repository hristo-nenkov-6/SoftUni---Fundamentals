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
        public static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            List<string> inputPeople = Console.ReadLine().Split(";").ToList();
            List<string> inputProducts = Console.ReadLine().Split(";").ToList();

            for(int i = 0; i < inputPeople.Count; i++)
            {
                string[] pers = inputPeople[i].Split('=').ToArray();
                string name = pers[0];
                double money = double.Parse(pers[1]);

                Person person = new Person(name, money);
                persons.Add(person);
            }

            for (int i = 0; i < inputProducts.Count; i++)
            {
                string[] prods = inputProducts[i].Split('=').ToArray();
                string name = prods[0];
                double cost = double.Parse(prods[1]);

                Product product = new Product(name, cost);
                products.Add(product);
            }

            string input = string.Empty;
            while((input = Console.ReadLine()) != "END")
            {
                string[] inp = input.Split(" ").ToArray();
                string person = inp[0];
                string product = inp[1];

                Person pers = persons.Find(name => name.Name == person);
                Product prod = products.Find(name => name.Name == product);

                pers.Buy(prod);
            }

            foreach(Person person in persons)
            {
                if(person.Products.Count == 0)
                {
                    Console.WriteLine(person.Name + " - Nothing bought");
                    continue;
                }
                Console.WriteLine(person.Name + " - " + String.Join(", ", person.Products));
            }
        }
        class Person
        {
            public Person(string name, double money)
            {
                Name = name;
                Money = money;
            }
            public string Name { get; set; }
            public double Money { get; set; }

            public List<string> Products = new List<string>();

            public void Buy(Product product)
            {
                IsAffordable();

                void IsAffordable()
                {
                    if(product.Cost <= Money)
                    {
                        Products.Add(product.Name);
                        Money -= product.Cost;
                        Console.WriteLine($"{Name} bought {product.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{Name} can't afford {product.Name}");
                    }
                }
            }
        }
        class Product
        {
            public Product(string name, double cost)
            {
                Name = name;
                Cost = cost;
            }
            public string Name { get; set; }
            public double Cost { get; set; }
        }
    }
}

/*
Peter=11;George=4
Bread=10;Milk=2
Peter Bread
George Milk
George Milk
Peter Milk
END
 */