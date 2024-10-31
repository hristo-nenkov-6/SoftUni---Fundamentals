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
            var input = Console.ReadLine()
                                 .ToLower()
                                 .Split(' ')
                                 .ToArray();

            var dict = new Dictionary<string, int>();
            foreach (string inp in input)
            {
                if(dict.ContainsKey(inp))
                {
                    dict[inp]++;
                }
                else
                {
                    dict.Add(inp, 1);
                }
            }
            
            foreach(var inp in dict.Where(x => x.Value % 2 == 1))
            {
                Console.Write(inp.Key + " ");
            }
        }
    }
}