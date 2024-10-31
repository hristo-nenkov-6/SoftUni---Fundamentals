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
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, List<string>>();
            for(int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();
                if(dict.ContainsKey(word))
                {
                    dict[word].Add(Console.ReadLine());
                }
                else
                {
                    dict.Add(word, new List<string>());
                    dict[word].Add(Console.ReadLine());
                }
            }
            foreach(var d in dict)
            {
                Console.WriteLine($"{d.Key} - {String.Join(", ", d.Value)}");
            }
        }
    }
}