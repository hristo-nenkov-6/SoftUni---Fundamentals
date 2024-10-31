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
            var dict = new Dictionary<string, List<double>>();
            
            for(int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if(dict.ContainsKey(name))
                {
                    dict[name].Add(grade);
                }
                else
                { 
                    dict.Add(name, new List<double>(){grade});
                }
            }

            foreach(var d in dict.Where(d => d.Value.Average() >= 4.5))
            {
                Console.WriteLine($"{d.Key} -> {d.Value.Average():f2}");
            }
        }
    }
}