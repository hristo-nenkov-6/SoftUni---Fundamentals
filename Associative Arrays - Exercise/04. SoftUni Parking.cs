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
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, string>();
            for(int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ").ToArray();
                string task = input[0];
                if (task == "register")
                {
                    string person = input[1];
                    string licencePlate = input[2];

                    if (dict.ContainsKey(person))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licencePlate}");
                    }
                    else
                    {
                        dict.Add(person, licencePlate);
                        Console.WriteLine($"{person} registered {licencePlate} successfully");
                    }
                }
                else
                {
                    string person = input[1];

                    if (!dict.ContainsKey(person))
                    {
                        Console.WriteLine($"ERROR: user {person} not found");
                    }
                    else
                    {
                        dict.Remove(person);
                        Console.WriteLine($"{person} unregistered successfully");
                    }
                }
            }

            foreach(var d in dict)
            {
                Console.WriteLine($"{d.Key} => {d.Value}");
            }
        }
    }
}