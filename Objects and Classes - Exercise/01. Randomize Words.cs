using System;
using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            List<string> phases = new List<string>()
            {"Excellent product.",
                "Such a great product.",
                "I always use thatproduct.",
                "Best product of its category.",
                "Exceptional product.",
                "I can'tlive without this product."};

            List<string> events = new List<string>()
            {"Now I feel good.",
                "I have succeeded with this product.",
                "Makesmiracles.I am happy of the results!",
                "I cannot believe but now I feelawesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"};

            List<string> authors = new List<string>()
            { "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"};

            List<string> cities = new List<string>()
                {"Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"};

            int messages = int.Parse(Console.ReadLine());
            for(int i = 0; i < messages; i++)
            {
                Random rdn = new Random();
                string[] message = new string[4];
                message[0] = phases[rdn.Next(0, 6)];
                message[1] = events[rdn.Next(0, 6)];
                message[2] = authors[rdn.Next(0, 6)];
                message[3] = cities[rdn.Next(0, 6)];

                Console.WriteLine(message[0] + " " + message[1] + " "
                    + message[2] + " - " + message[3]);
            }
        }
    }
}