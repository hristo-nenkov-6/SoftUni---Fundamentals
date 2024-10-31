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
            var dict = new Dictionary<string, List<string>>();
            string input = string.Empty;

            while((input = Console.ReadLine()) != "End")
            {
                string[] inp = input.Split(" -> ").ToArray();
                string company = inp[0];
                string ID = inp[1];

                if(dict.ContainsKey(company))
                {
                    if (!dict[company].Contains(ID))
                    {
                        dict[company].Add(ID);
                    }
                }
                else
                {
                    dict.Add(company, new List<string>() { ID });
                }
            }

            foreach(var d in dict)
            {
                Console.WriteLine(d.Key);
                foreach(var v in d.Value)
                {
                    Console.WriteLine("-- " + v);
                }
            }
        }
    }
}