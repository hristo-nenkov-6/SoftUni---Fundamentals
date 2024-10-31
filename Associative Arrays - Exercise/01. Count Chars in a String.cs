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
            var dict = new Dictionary<char, int>();
            var input = Console.ReadLine().Replace(" ", "").ToCharArray();

            foreach(char c in input)
            {
                if(dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            foreach(var d in dict)
            {
                Console.WriteLine(d.Key + " -> " + d.Value);
            }
        }
    }
}