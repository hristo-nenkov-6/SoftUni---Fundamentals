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

            while((input = Console.ReadLine()) != "end")
            {
                string[] inp = input.Split(" : ").ToArray();
                string nameOfCourse = inp[0];
                string student = inp[1];

                if(dict.ContainsKey(nameOfCourse))
                {
                    dict[nameOfCourse].Add(student);
                }
                else
                {
                    dict.Add(nameOfCourse, new List<string>());
                    dict[nameOfCourse].Add(student);
                }
            }

            foreach(var d in dict)
            {
                List<string> list = dict[d.Key];
                Console.WriteLine($"{d.Key}: {list.Count}");
                foreach(string name in list)
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}