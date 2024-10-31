using System;
using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Xml.Schema;
using System.Net.WebSockets;

namespace ConsoleApp3
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, double[]>();

            string input = string.Empty;
            while((input = Console.ReadLine()) != "buy")
            {
                var list = input.Split().ToList();
                string name = list[0];
                double price = double.Parse(list[1]);
                int quantity = int.Parse(list[2]);


                if(dict.ContainsKey(name))
                {
                    if (dict[name][0].Equals(price))
                    {
                        dict[name][1] += quantity;
                    }
                    else
                    {
                        dict[name][0] = price;
                        dict[name][1] += quantity;
                    }
                }
                else
                {
                    double[] arr = new double[2] {price, quantity};
                    dict.Remove(name);
                    dict.Add(name, arr);
                }
            }

            foreach(var d in dict)
            {
                double[] arr = d.Value;
                double all = arr[0] * arr[1];
                Console.WriteLine($"{d.Key} -> {all:f2}");
            }
        }
    }
}