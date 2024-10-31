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
            string inp = Console.ReadLine();
                         inp
                         .Split(" ")
                         .Where(x => x.Length % 2 == 0)
                         .ToList()
                         .ForEach(x => Console.WriteLine(x));
        }
    }
}