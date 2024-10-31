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
            double[] numbers = Console.ReadLine()
                                      .Split()
                                      .Select(double.Parse)
                                      .ToArray();

            var dict = new SortedDictionary<double, int>();
            foreach (double number in numbers)
            {
                if(!dict.ContainsKey(number))
                {
                    dict.Add(number, 1);
                }
                else { dict[number]++; }
            }

            foreach (var number in dict)
            {
                Console.WriteLine(number.Key + " -> " + number.Value);
            }
        }
    }
}