using System;
using System.Reflection.Metadata.Ecma335;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fileName = Console.ReadLine().Split("\\");
            string[] useful = fileName[fileName.Length - 1].Split(".").ToArray();

            string name = useful[0];
            string extension = useful[1];

            Console.WriteLine("File name: " + name);
            Console.WriteLine("File extension: " + extension);
        }
    }
}