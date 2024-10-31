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
                                    .Select(int.Parse)
                                    .ToList();
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0) 
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            if(list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                list.Reverse();
                Console.WriteLine(String.Join(" ", list));
            }
        }
    }
}