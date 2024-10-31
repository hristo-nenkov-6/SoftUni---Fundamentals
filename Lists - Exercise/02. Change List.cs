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
                                    .Select (int.Parse) .ToList ();
            int iterations = list.Count / 2;

            List<int> newlist = new List<int> ();

            for(int i = 0; i < iterations; i++)
            {
                newlist.Add(list[i] + list[list.Count - i - 1]);
            }
            if(list.Count % 2 == 1)
            {
                newlist.Add(list[iterations]);
            }
            Console.WriteLine(String.Join(" ", newlist));
        }
    }
}