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
            var dict = new Dictionary<string, int>();

            string input = string.Empty;
            while((input = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if(dict.ContainsKey(input))
                {
                    dict[input] += quantity;
                }
                else
                {
                    dict.Add(input, quantity);
                }
            }

            foreach (var d in dict)
            {
                Console.WriteLine(d.Key + " -> " + d.Value);
            }
        }
    }
}