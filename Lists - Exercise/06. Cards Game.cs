using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                                    .Split(" ")
                                    .Select (int.Parse)
                                    .ToList ();

            string input = string.Empty;
            while((input = Console.ReadLine()) != "end")
            {
                string[] splittedInput = input.Split(' ').ToArray();
                switch(splittedInput[0])
                {
                    case "Add":
                        list.Add(int.Parse(splittedInput[1]));
                        break;

                    case "Remove":
                        list.Remove(int.Parse(splittedInput[1]));
                        break;

                    case "RemoveAt":
                        list.RemoveAt(int.Parse(splittedInput[1]));
                        break;

                    case "Insert":
                        list.Insert(int.Parse(splittedInput[2]), int.Parse(splittedInput[1]));
                        break;
                }
            }

            Console.WriteLine(String.Join(" ", list));
        }
    }
}